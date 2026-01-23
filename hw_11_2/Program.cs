using System;
namespace hw_11_2
{
    enum StoreType
    {
        Grocery,
        Household,
        Clothing,
        Footwear
    }

    class Play : IDisposable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

        private bool disposed = false;

        public Play(string title, string author, string genre, int releaseYear)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ReleaseYear = releaseYear;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Release Year: " + ReleaseYear);
            Console.WriteLine();
        }

        public void Dispose()
        {
            if (!disposed)
            {
                disposed = true;
                Console.WriteLine("Dispose called for play: " + Title);
                GC.SuppressFinalize(this);
            }
        }

        ~Play()
        {
            Dispose();
        }
    }

    class Store
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public StoreType Type { get; set; }

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

        ~Store()
        {
            Console.WriteLine("Destructor called for store: " + Name);
        }
    }

    class Program
    {
        static void Main()
        {
            Play play = new Play(
                "Hamlet",
                "William Shakespeare",
                "Tragedy",
                1603
            );

            play.ShowInfo();
            play.Dispose();

            Store store = new Store(
                "De Facto",
                "Vodna 5",
                StoreType.Grocery
            );

            store.ShowInfo();
            store = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Program finished");
        }
    }
}
