using System;
using System.Linq;
namespace hw_14
{
    class Phone
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Phone[] phones = new Phone[]
         {
            new Phone { Name = "iPhone 17", Manufacturer = "Apple", Price = 1999, ReleaseDate = new DateTime(2025, 9, 16) },
            new Phone { Name = "Galaxy S25", Manufacturer = "Samsung", Price = 899, ReleaseDate = new DateTime(2023, 2, 17) },
            new Phone { Name = "Pixel 8", Manufacturer = "Google", Price = 799, ReleaseDate = new DateTime(2023, 10, 4) },
            new Phone { Name = "Nokia G50", Manufacturer = "Nokia", Price = 350, ReleaseDate = new DateTime(2021, 10, 15) },
            new Phone { Name = "OnePlus 13T", Manufacturer = "OnePlus", Price = 699, ReleaseDate = new DateTime(2024, 1, 7) }
         };

            int totalPhones = phones.Count();
            int phonesOver100 = phones.Count(p => p.Price > 100);
            int phonesInRange = phones.Count(p => p.Price >= 400 && p.Price <= 700);
            int specificManufacturer = phones.Count(p => p.Manufacturer == "Apple");

            Phone minPricePhone = phones.OrderBy(p => p.Price).First();
            Phone maxPricePhone = phones.OrderByDescending(p => p.Price).First();
            Phone oldestPhone = phones.OrderBy(p => p.ReleaseDate).First();
            Phone newestPhone = phones.OrderByDescending(p => p.ReleaseDate).First();
            decimal averagePrice = phones.Average(p => p.Price);

            Console.WriteLine($"Total phones: {totalPhones}");
            Console.WriteLine($"Phones over $100: {phonesOver100}");
            Console.WriteLine($"Phones priced between $400 and $700: {phonesInRange}");
            Console.WriteLine($"Phones by Apple: {specificManufacturer}");
            Console.WriteLine($"Phone with minimum price: {minPricePhone.Name}, ${minPricePhone.Price}");
            Console.WriteLine($"Phone with maximum price: {maxPricePhone.Name}, ${maxPricePhone.Price}");
            Console.WriteLine($"Oldest phone: {oldestPhone.Name}, released on {oldestPhone.ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Newest phone: {newestPhone.Name}, released on {newestPhone.ReleaseDate.ToShortDateString()}");
            Console.WriteLine($"Average price: ${averagePrice}");
        }
    }
}
