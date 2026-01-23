using System;
namespace hw_11_1
{

    enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    class Store : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public StoreType Type { get; set; }

        private bool disposed = false;

        public Store(string name, string address, StoreType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                Console.WriteLine("Dispose called for store: " + Name);
                GC.SuppressFinalize(this);
            }
        }

        ~Store()
        {
            Dispose();
        }
    }

    class Program
    {
        static void Main()
        {
            Store store1 = new Store(
                "De Facto",
                "Vodna 5",
                StoreType.Grocery
            );

            store1.ShowInfo();
            store1.Dispose();

            using (Store store2 = new Store(
                "Sinsay",
                "Gavanna 10",
                StoreType.Clothing
            ))
            {
                store2.ShowInfo();
            }

            Console.WriteLine("Program finished");
        }
    }
}
