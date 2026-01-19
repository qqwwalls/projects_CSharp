using System;
using System.Collections.Generic;
namespace hw_9;
public class Item
{
public string Name { get; set; }
public double Volume { get; set; }

public Item(string name, double volume)
{
    Name = name;
    Volume = volume;
}
}

public class Backpack
{
public string Color { get; set; }
public string Brand { get; set; }
public string Fabric { get; set; }
public double Weight { get; set; }
public double Capacity { get; set; }
public List<Item> Contents { get; private set; }

public event Action<Item> ItemAdded;
public event Action<Item> ItemRemoved;
public event Action<Item, double> ItemChanged;

public Backpack()
{
    Contents = new List<Item>();
}

public double CurrentVolume => Contents.Sum(i => i.Volume);

public void AddItem(Item item)
{
    if (CurrentVolume + item.Volume > Capacity)
        throw new InvalidOperationException("Backpack capacity exceeded");

    Contents.Add(item);
    ItemAdded?.Invoke(item);
}

public void RemoveItem(Item item)
{
    if (Contents.Remove(item))
        ItemRemoved?.Invoke(item);
}

public void ChangeItemVolume(Item item, double newVolume)
{
    double volumeWithoutItem = CurrentVolume - item.Volume;

    if (volumeWithoutItem + newVolume > Capacity)
        throw new InvalidOperationException("Backpack capacity exceeded");

    double oldVolume = item.Volume;
    item.Volume = newVolume;
    ItemChanged?.Invoke(item, oldVolume);
}
}

class Program
{
static void Main()
{
    Backpack backpack = new Backpack
    {
        Color = "Black",
        Brand = "Nike",
        Fabric = "Cotton",
        Weight = 1.5,
        Capacity = 10
    };

    backpack.ItemAdded += delegate (Item item)
    {
        Console.WriteLine($"Added: {item.Name}");
    };

    backpack.ItemRemoved += delegate (Item item)
    {
        Console.WriteLine($"Removed: {item.Name}");
    };

    backpack.ItemChanged += delegate (Item item, double oldVolume)
    {
        Console.WriteLine($"Changed: {item.Name} {oldVolume} -> {item.Volume}");
    };

    Item book = new Item("Book", 5);
    Item wallet = new Item("Wallet", 3);

    backpack.AddItem(book);
    backpack.AddItem(wallet);
    backpack.ChangeItemVolume(book, 6);
    backpack.RemoveItem(wallet);
}
}
