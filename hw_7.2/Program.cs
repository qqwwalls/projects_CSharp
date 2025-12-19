using System;

namespace hw_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product banana = new Product("Banana", 23, 120.99m);
            Product orange = new Product("Orange", 32, 99.50m);
            Product coconut = new Product("Coconut", 20, 120.99m);
            banana += 5;
            orange -= 10;

            Console.WriteLine(banana);
            Console.WriteLine(orange);
            Console.WriteLine(coconut);

            Console.WriteLine("\nPrice comparison:");
            Console.WriteLine($"Banana == Coconut: {banana == coconut}");
            Console.WriteLine($"Banana != Orange: {banana != orange}");

            Console.WriteLine("\nQuantity comparison:");
            Console.WriteLine($"Orange > Banana: {orange > banana}");
            Console.WriteLine($"Coconut < Banana: {coconut < banana}");
        }
    }
}
