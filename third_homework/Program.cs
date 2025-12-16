namespace third_homework
{
    internal class Program
    {
        static void Square(int side, char symbol)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(symbol + " ");
                }
                Console.WriteLine();
            }
        }
        static bool Palindrome(int num)
        {
            int orig = num;
            int reversed = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reversed = reversed * 10 + digit;
                num /= 10;
            }

            return orig == reversed;
        }
        static int[] Arr(int[] arr1, int[] arr2)
        {
            int count = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    count++;
            }
            int[] result = new int[count];
            int index = 0;

            for (int i = 0; i < arr1.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result[index] = arr1[i];
                    index++;
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            /*Напишіть метод, який відображає квадрат з деякого символу. 
            Метод приймає як параметр: довжину сторони квадрата, символ.*/
            Console.WriteLine("Enter side length of square: ");
            int side = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter symbol:");
            char symbol = char.Parse(Console.ReadLine());
            Square(side, symbol);

            /*Напишіть метод, який перевіряє чи є передане число "паліндромом".
            Число передається як параметр. Якщо число паліндром, потрібно повернути з методу true, інакше — false.*/
            Console.WriteLine("\nEnter your number: ");
            int number;
            number= int.Parse(Console.ReadLine());
            Console.WriteLine("Is your number palindrome? ");
            Console.WriteLine(Palindrome(number));

            /*Напишіть метод, що фільтрує масив на підставі переданих параметрів.
            Метод приймає параметри: оригінальний_масив, масив_з_даними_для_фільтрації.
            Метод повертає оригінальний масив без елементів, які є в масиві для фільтрації.*/
            Console.WriteLine("\nEnter size of your array:");
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];

            Console.WriteLine("Enter elements of your array:");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEnter size of your array for filtration:");
            int m = int.Parse(Console.ReadLine());
            int[] arr2 = new int[m];

            Console.WriteLine("Enter elements of your array:");
            for (int i = 0; i < m; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            int[] res = Arr(arr1, arr2);
            Console.WriteLine("\nFiltered array: ");   
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
