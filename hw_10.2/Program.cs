namespace hw_10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category<string> electronics = new Category<string>();

            electronics.Add(new Product<string>(
                "Electronics", "Laptop", 2200, DateTime.Now.AddDays(-10)));

            electronics.Add(new Product<string>(
                "Electronics", "Mouse", 50, DateTime.Now.AddDays(-40)));

            electronics.Add(new Product<string>(
                "Electronics", "Keyboard", 600, DateTime.Now.AddDays(-5)));

            Console.WriteLine("All products");
            foreach (var product in electronics)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nPrice from 100 to 500");
            foreach (var product in electronics.GetByPriceRange(100, 500))
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("\nAdded in last 30 days");
            foreach (var product in electronics.GetAddedInLastDays(30))
            {
                Console.WriteLine(product);
            }
        }
    }
}
