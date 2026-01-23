using System;

namespace hw_11
{
    class Play
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int ReleaseYear { get; set; }

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

        ~Play()
        {
            Console.WriteLine("Destructor called for: " + Title);
        }
    }

    class Program
    {
        static void Main()
        {
            Play play1 = new Play(
                "Hamlet",
                "William Shakespeare",
                "Drama",
                1603
            );

            play1.ShowInfo();

            play1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("Program finished");
        }
    }
}
