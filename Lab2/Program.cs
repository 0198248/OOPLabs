using System;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Лабораторна робота No2");


            Console.Write("Введіть x: ");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.Write("\nНевірно введене число, спробуйте ще раз: ");

            Console.Write("Введіть a: ");
            double a;
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("\nНевірно введене число, спробуйте ще раз: ");

            double y;
            if (x == a)
                y = Math.Exp(Math.Abs(x + a)) * Math.Sin(x);
            else if (x > a && x < a * a)
                y = Math.Pow(x - a, 2) * Math.Pow(Math.Cos(x), 2);
            else
            {
                Console.WriteLine("Для цього x функція не визначена.");
                return;
            }

            Console.WriteLine($"y = {Math.Round(y, 4)}");


            double[] qValues = { 0.1, 0.3, 1.1, 1.25, 1.9, 2.8 };

            for (int i = 0; i <= 800 / 15; i++)
            {
                double y1 = i * 0.15;
                double x1;

                if (y1 < 0.6)
                {
                    x1 = y1 * y1 + y1 + 1;
                }
                else if (y1 >= 1)
                {
                    x1 = y1 - 1;
                }
                else
                {
                    Console.WriteLine($"y = {Math.Round(y1, 4)}");
                    Console.WriteLine("ФУНКЦІЯ НЕ ЗНАЙДЕНА");
                    continue;
                }

                double p = Math.Sqrt(Math.Exp(x1 - 2) + x1);

                Console.WriteLine($"y = {Math.Round(y1,4)}; x = {Math.Round(x1, 4)}; p = {Math.Round(p, 4)}");
            }

            foreach (double q in qValues)
            {
                Console.WriteLine($"q = {q}");
            }
        }
    }
}