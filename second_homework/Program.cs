namespace second_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дано 2 масиви розмірності M і N відповідно.
             Необхідно переписати до третього масиву загальні елементи перших двох масивів без повторень.*/
            Random rand = new Random();

            Console.Write("Enter size of first array: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Enter size of second array: ");
            int n = int.Parse(Console.ReadLine());

            int[] array1 = new int[m];
            int[] array2 = new int[n];

            for (int i = 0; i < m; i++)
                array1[i] = rand.Next(1, 10);

            for (int i = 0; i < n; i++)
                array2[i] = rand.Next(1, 10);

            Console.WriteLine("Array 1:");
            for (int i = 0; i < m; i++)
                Console.Write(array1[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Array 2:");
            for (int i = 0; i < n; i++)
                Console.Write(array2[i] + " ");
            Console.WriteLine();

            Console.WriteLine("Common elements without duplicates:");
            for (int i = 0; i < m; i++)
            {
                bool show = false;
                for (int k = 0; k < i; k++)
                {
                    if (array1[i] == array1[k])
                    {
                        show = true;
                        break;
                    }
                }

                if (show)
                    continue;

                for (int j = 0; j < n; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        Console.Write(array1[i] + " ");
                        break;
                    }
                }
            }
            /*Користувач вводить речення з клавіатури. Вам необхідно підрахувати кількість слів у ньому.*/
            Console.Write("\nEnter a sentence: ");
            string sentence = Console.ReadLine();
            int count = 0;
            bool word = false;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ' && !word)
                {
                    word = true;
                    count++;
                }
                else if (sentence[i] == ' ')
                {
                    word = false;
                }
            }
            Console.WriteLine("Number of words: " + count);
            /*Користувач вводить речення з клавіатури. Вам необхідно перевернути кожне слово речення і відобразити результат на екран.*/
            Console.Write("\nEnter a sentence: ");
            string sentence2 = Console.ReadLine();
            bool word2 = false;
            int start = 0;

            for (int i = 0; i <= sentence2.Length; i++)
            {
                if (i < sentence2.Length && sentence2[i] != ' ' && !word2)
                {
                    word2 = true;
                    start = i;
                }
                else if (i == sentence2.Length || sentence2[i] == ' ')
                {
                    if (word2)
                    {
                        int length = i - start;
                        char[] word2Array = new char[length];
                        for (int j = 0; j < length; j++)
                            word2Array[j] = sentence2[start + j];

                        Array.Reverse(word2Array);
                        Console.Write(new string(word2Array));

                        if (i != sentence2.Length)
                            Console.Write(' ');

                        word2 = false;
                    }
                }
            }
        }
    }
}
