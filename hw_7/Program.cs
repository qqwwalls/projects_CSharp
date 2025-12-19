namespace hw_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureArray tempArray = new TemperatureArray();

            Console.WriteLine("Enter the temperature for each day of the week:");
            Console.WriteLine("0 - Monday, 1 - Tuesday, 2 - Wednesday, 3 - Thursday, 4 - Friday, 5 - Saturday, 6 - Sunday");
            Console.WriteLine();

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"Day {i}: ");
                tempArray[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine($"Average temperature for the week: {tempArray.Avarage_temp():F2} °C");

        }
    }
}
