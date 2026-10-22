using System;
using System.Text;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Лабораторна робота No5\n");

            int N = 20;
            int minValue = -60;
            int maxValue = 75;
            int P = -20;
            int variant = 23;

            PrintStudentInfo("Пламетюк Денис", "ІПЗ22", variant);

            int[] numbers = CreateRandomArray(N, minValue, maxValue, variant);

            PrintArray("Початковий масив:", numbers);

            Console.WriteLine($"Сума елементів: {Sum(numbers)}");
            Console.WriteLine($"Середнє арифметичне: {Average(numbers):F2}");
            Console.WriteLine($"Мінімальний елемент: {FindMinimum(numbers)}");
            Console.WriteLine($"Максимальний елемент: {FindMaximum(numbers)}");

            Console.WriteLine($"\nКількість елементів, найближчих до P = {P}:");
            int closestIndex = FindClosestIndex(numbers, P);
            Console.WriteLine($"Індекс найближчого елемента: {closestIndex}");
            Console.WriteLine($"Значення елемента: {numbers[closestIndex]}");

            int[] testNumbers = { -35, -20, -18, 0, 15, 40 };
            int testP = -20;

            PrintArray("\nКонтрольний масив:", testNumbers);

            int testClosestIndex = FindClosestIndex(testNumbers, testP);
            Console.WriteLine($"P = {testP}");
            Console.WriteLine($"Індекс найближчого елемента: {testClosestIndex}");
            Console.WriteLine($"Значення елемента: {testNumbers[testClosestIndex]}");

            Console.Write("\nВведіть текст: ");
            string? text = Console.ReadLine();

            while (text == null)
            {
                Console.Write("Не вдалося прочитати текст. Спробуйте ще раз: ");
                text = Console.ReadLine();
            }

            string normalizedText = RemoveExtraSpaces(text);

            Console.WriteLine($"Початковий текст: [{text}]");
            Console.WriteLine($"Текст без зайвих пробілів: [{normalizedText}]");
            Console.WriteLine($"Кількість слів: {CountWords(text)}");
        }

        static void PrintStudentInfo(string fullName, string group, int variant)
        {
            Console.WriteLine($"Студент: {fullName}");
            Console.WriteLine($"Група: {group}");
            Console.WriteLine($"Варіант: {variant}\n");
        }

        static int[] CreateRandomArray(int length, int minValue, int maxValue, int seed)
        {
            int[] numbers = new int[length];
            Random rand = new Random(seed);

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rand.Next(minValue, maxValue + 1);

            return numbers;
        }

        static void PrintArray(string title, int[] numbers)
        {
            Console.WriteLine(title);

            foreach (int number in numbers)
                Console.Write($"{number} ");

            Console.WriteLine();
        }

        static int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
                sum += number;

            return sum;
        }

        static double Average(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            return (double)Sum(numbers) / numbers.Length;
        }

        static int FindMinimum(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] < min)
                    min = numbers[i];

            return min;
        }

        static int FindMaximum(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
                if (numbers[i] > max)
                    max = numbers[i];

            return max;
        }

        static int FindClosestIndex(int[] numbers, int p)
        {
            int closestIndex = 0;
            int minDistance = Math.Abs(numbers[0] - p);

            for (int i = 1; i < numbers.Length; i++)
            {
                int distance = Math.Abs(numbers[i] - p);

                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestIndex = i;
                }
            }

            return closestIndex;
        }

        static int CountWords(string text)
        {
            string normalizedText = RemoveExtraSpaces(text);

            if (normalizedText.Length == 0)
                return 0;

            string[] words = normalizedText.Split(
                new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries);

            return words.Length;
        }

        static string RemoveExtraSpaces(string text)
        {
            StringBuilder result = new StringBuilder();
            bool previousWasWhitespace = true;

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsWhiteSpace(text[i]))
                {
                    if (!previousWasWhitespace)
                    {
                        result.Append(' ');
                        previousWasWhitespace = true;
                    }
                }
                else
                {
                    result.Append(text[i]);
                    previousWasWhitespace = false;
                }
            }

            if (result.Length > 0 && result[result.Length - 1] == ' ')
                result.Length--;

            return result.ToString();
        }
    }
}