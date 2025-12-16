namespace _4_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Information about your journal:");
            Journal journal = new Journal("Vampire Diaries", 1486, "Report", "+3-488-JDBH", "+380 97 3409 233", "smth@gmail.com");
            journal.show();
        }
    }
}
