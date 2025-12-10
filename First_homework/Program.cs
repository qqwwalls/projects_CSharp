namespace First_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Користувач вводить із клавіатури два числа. Перше число — це значення, друге число відсоток, який необхідно порахувати. 
             * Наприклад, ми ввели з клавіатури 90 і 10. Потрібно вивести на екран 10 відсотків від 90. Результат: 9.*/
            double n;
            Console.WriteLine("Enter number: ");
            n= int.Parse(Console.ReadLine());
            double m;
            Console.WriteLine("Enter a procent: ");
            m= int.Parse(Console.ReadLine());
            double res = n * m/100;
            Console.WriteLine($"{m} procents from {n} it`s: {res}");
            /*Користувач вводить із клавіатури чотири цифри. Необхідно створити число, що містить ці цифри.
             Наприклад, якщо з клавіатури введено 1, 5, 7, 8, тоді потрібно сформувати число 1578.*/
            int result = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Enter digit {i + 1}: ");
                int digit = int.Parse(Console.ReadLine());
                result = result * 10 + digit;
            }
            Console.WriteLine("Result number: " + result);
            /*Користувач вводить із клавіатури показання температури. 
           Залежно від вибору користувача програма переводить температуру з Фаренгейта в Цельсій або навпаки.*/
            Console.Write("Enter temperature value: ");
            double temp = double.Parse(Console.ReadLine());
            Console.Write("Choose 1: F to C or 2: C to F: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                double c = (temp - 32) * 5 / 9;
                Console.WriteLine("Celsius: " + c);
            }
            else if (choice == 2)
            {
                double f = temp * 9 / 5 + 32;
                Console.WriteLine("Fahrenheit: " + f);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            /*Користувач вводить число. Програма повинна визначити, чи є це число досконалим.
            Досконале число — це число, яке дорівнює сумі всіх своїх дільників, крім самого себе (наприклад, 28 = 1 + 2 + 4 + 7 + 14)*/
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                    sum += i;
            }

            if (sum == num)
                Console.WriteLine("Perfect number");
            else
                Console.WriteLine("Not perfect");
        }
    }
    }

