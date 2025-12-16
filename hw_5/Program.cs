namespace hw_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Створіть додаток "Калькулятор" для переведення числа з однієї системи числення в іншу.
             * Користувач за допомогою меню вибирає напрямок переведення. Наприклад, з десяткової в двійкову.
             * Після вибору напрямку, користувач вводить число у вихідній системі числення.
             * Додаток має перевести число в потрібну систему. Передбачити випадок виходу за межі діапазону,
             * що визначається типом int, неправильне введення.*/
            while (true)
            {
                Console.WriteLine("\nCalculator");
                Console.WriteLine("1 - decimal to binary");
                Console.WriteLine("2 - binary to decimal");
                Console.WriteLine("0 - Exit");
                Console.Write("Choose option: ");

                string choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            DecimalToBinary();
                            break;

                        case "2":
                            BinaryToDecimal();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Option doesn`t exist.");
                            break;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Error: number more than int.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: wrong format data.");
                }
            }
        }

        static void DecimalToBinary()
        {
            Console.Write("Enter decimal number: ");

            checked
            {
                int number = int.Parse(Console.ReadLine());
                string binary = Convert.ToString(number, 2);
                Console.WriteLine($"Binary: {binary}");
            }
        }

        static void BinaryToDecimal()
        {
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();

            foreach (char c in binary)
            {
                if (c != '0' && c != '1')
                    throw new FormatException();
            }

            checked
            {
                int result = Convert.ToInt32(binary, 2);
                Console.WriteLine($"Decimal: {result}");
            }
        
       }
    }
}
