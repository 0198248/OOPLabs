using Lab7Library.Calculations;
using Lab7Library.TextProcessing;
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

            Console.WriteLine("Лабораторна робота No7\n");
            Console.WriteLine("Студент: Пламетюк Денис");
            Console.WriteLine("Група: ІПЗ22");
            Console.WriteLine("Варіант: 23\n");

            Console.WriteLine("середнє трьох чисел: ");

            double a = 10, b = 20, c = 30;

            double average = MathTools.CalculateAverage(a, b, c);

            Console.WriteLine($"Перше число: {a}");
            Console.WriteLine($"Друге число: {b}");
            Console.WriteLine($"Третє число: {c}");
            Console.WriteLine($"Середнє арифметичне: {Math.Round(average,2)}");

            double aTest = -5, bTest = 0, cTest = 5;

            double sAverage = MathTools.CalculateAverage(aTest, bTest, cTest);

            Console.WriteLine("\nДругий тест математичного методу:");
            Console.WriteLine($"Числа: {aTest}, {bTest}, {cTest}");
            Console.WriteLine($"Середнє арифметичне: {Math.Round(sAverage, 2)}");

            Console.WriteLine("\nперевертання рядка: ");

            Console.Write("Введіть текст: ");
            string? text = Console.ReadLine();

            string reversedText = Lab7Library.TextProcessing.TextTools.ReverseText(text);

            Console.WriteLine($"Початковий текст: [{text}]");
            Console.WriteLine($"Текст у зворотному порядку: [{reversedText}]");

            string testText = "Просто текст";
            string reversedTestText = Lab7Library.TextProcessing.TextTools.ReverseText(testText);

            Console.WriteLine("\nДругий тест текстового методу:");
            Console.WriteLine($"Початковий текст: [{testText}]");
            Console.WriteLine($"Результат: [{reversedTestText}]");

            //Короткий запис:
            Console.WriteLine(TextTools.ReverseText("Луцьк"));


        }
    }
}
