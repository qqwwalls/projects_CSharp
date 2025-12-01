namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("It's easy to win forgiveness for being wrong;");
            Console.WriteLine("\tbeing right is what gets you into real trouble.");
            Console.WriteLine("Bjarne Stroustrup");
            //2
            int sum = 0;
            int product = 1;

            Console.Write("Enter number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            int min = number1;
            int max = number1;

            sum += number1;
            product *= number1;
            for (int i = 2; i <= 5; i++)
            {
                Console.Write($"Enter number {i}: ");
                number1 = int.Parse(Console.ReadLine());

                sum += number1;
                product *= number1;

                if (number1 < min) min = number1;
                if (number1 > max) max = number1;
            }

            Console.WriteLine($"Sum of elements: {sum}");
            Console.WriteLine($"Multiply of elements: {product}");
            Console.WriteLine($"Minimum value: {min}");
            Console.WriteLine($"Maximum value: {max}");
            //3
            Console.WriteLine("Enter a six-digit number:");
            int number = int.Parse(Console.ReadLine());

            if (number < 100000 || number > 999999)
            {
                Console.WriteLine("The number must be six-digit!");
                return;
            }

            int reverse = 0;

            int count = 6; 

            while (count > 0)
            {
                int digit = number % 10;      
                reverse = reverse * 10 + digit; 
                number /= 10;                
                count--;
            }

            Console.WriteLine($"Reversed number: {reverse}");
        }
    }
}
