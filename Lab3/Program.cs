using System;
using System.Collections.Generic;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Лабораторна робота No3");

            int minValue = -90;
            int maxValue = 90;
            int N = 20;
            int P = 7;

            int[] nums = new int[N];
            Random rand = new Random(23);

            for (int x = 0; x < nums.Length; x++)
                nums[x] = rand.Next(minValue, maxValue);

            Console.WriteLine("Масив до розвороту:");
            foreach (int num in nums)
                Console.Write($"{num}, ");

            ArrReverse(nums);

            Console.WriteLine("\nМасив після розвороту:");
            foreach (int num in nums)
                Console.Write($"{num}, ");

            Console.WriteLine($"\nСума: {Sum(nums)}");

            Console.WriteLine($"Середнє арифметичне: {Avr(nums)}");

            int min, minP;
            Min(nums, out min, out minP);
            Console.WriteLine($"Мінімальний елемент: {min}, індекс його першого входження: {minP + 1}");

            int max, maxP;
            Max(nums, out max, out maxP);
            Console.WriteLine($"Максимальний елемент: {max}, індекс його першого входження: {maxP + 1}");

            List<int> elements = new List<int>();

            foreach (int num in nums)
                if ((num % P) == 0)
                    elements.Add(num);

            if (elements.LongCount() != 0)
            {
                Console.WriteLine($"Елементи, кратні {P}:");
                foreach (int num in elements)
                    Console.Write($"{num}, ");

                Console.WriteLine($"\nЇх кількість: {elements.LongCount()}," +
                    $" сума: {Sum(elements)} та" +
                    $" середнє арифметичне: {(double)Sum(elements) / elements.LongCount()}");
            }
            else
                Console.WriteLine($"Немає елементів, кратних {P}");

            Array.Sort(nums);
            Console.WriteLine("Відсортований масив:");
            foreach (int num in nums)
                Console.Write($"{num}, ");

            int[,] nums2D = new int[4, 4];
            Console.WriteLine("\nДвовимірний масив:");

            for (int num1 = 0; num1 < nums2D.GetLength(0); num1++)
            {
                for (int num2 = 0; num2 < nums2D.GetLength(1); num2++)
                {
                    nums2D[num1, num2] = rand.Next(minValue, maxValue);
                    Console.Write(nums2D[num1, num2] + "\t");
                }
                Console.WriteLine("");
            }

            int sum = 0, m = 0, n = 0;

            Console.WriteLine("");

            for (int num1 = 0; num1 < nums2D.GetLength(0); num1++)
            {
                for (int num2 = 0; num2 < nums2D.GetLength(1); num2++)
                    sum += nums2D[num1, num2];

                Console.WriteLine($"Сума рядка {num1 + 1}: {sum}");

                if (num1 == 0 || m < sum)
                {
                    m = sum;
                    n = num1;
                }

                sum = 0;
            }

            Console.WriteLine($"Індекс рядка з найбільшою сумою: {n} та значення цієї суми: {m}");
        }

        static int Sum(int[] nums)
        {
            int summa = 0;
            foreach (int x in nums)
                summa += x;

            return summa;
        }

        static void ArrReverse(int[] nums1)
        {
            for (int x = 0; x < nums1.Length / 2; x++)
            {
                int temp = nums1[x];
                nums1[x] = nums1[nums1.Length - 1 - x];
                nums1[nums1.Length - 1 - x] = temp;
            }
        }

        static int Sum(List<int> nums)
        {
            int summa = 0;
            foreach (int x in nums)
                summa += x;

            return summa;
        }

        static double Avr(int[] nums)
        {
            int summa = 0;
            foreach (int x in nums)
                summa += x;

            return (double)summa / nums.Length;
        }

        static void Min(int[] nums, out int summa, out int place)
        {
            summa = nums[0];
            place = 0;

            for (int x = 0; x < nums.Length; x++)
            {
                if (summa > nums[x])
                {
                    summa = nums[x];
                    place = x;
                }
            }
        }

        static void Max(int[] nums, out int summa, out int place)
        {
            summa = nums[0];
            place = 0;

            for (int x = 0; x < nums.Length; x++)
            {
                if (summa < nums[x])
                {
                    summa = nums[x];
                    place = x;
                }
            }
        }
    }
}