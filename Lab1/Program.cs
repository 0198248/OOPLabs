using System;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Лабораторна робота No1");

            Console.Write("Введіть прізвище та ім’я: ");
            string? name = Console.ReadLine();

            Console.Write("Введіть групу: ");
            string? group = Console.ReadLine();

            Console.Write("Введіть номер варіанта: ");
            string? variant = Console.ReadLine();

            Console.WriteLine($"\nВиконав: {name}");
            Console.WriteLine($"Група: {group}");
            Console.WriteLine($"Варіант: {variant}\n");

            Console.Write("Введіть x: ");
            double x;

            while (!double.TryParse(Console.ReadLine(), out x))
                Console.Write("\nНевірно введене число, спробуйте ще раз: ");

            Console.Write("Введіть z: ");
            double z;

            while (!double.TryParse(Console.ReadLine(), out z))
                Console.Write("\nНевірно введене число, спробуйте ще раз: ");

            double y = Math.Max(Math.Abs(x), Math.Abs(z)) + Math.Min(x, z);

            Console.WriteLine($"Для x({x}) і z({z})");
            Console.WriteLine($"y = {Math.Round(y, 4)}");


            Console.WriteLine("\n==================================");
            Console.WriteLine("Корені квадратного рівняння");
            Console.WriteLine("==================================");

            double a, b, c;

            Console.Write("Введіть коефіцієнт a: ");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Невірне число. Введіть a ще раз: ");

            Console.Write("Введіть коефіцієнт b: ");
            while (!double.TryParse(Console.ReadLine(), out b))
                Console.Write("Невірне число. Введіть b ще раз: ");

            Console.Write("Введіть коефіцієнт c: ");
            while (!double.TryParse(Console.ReadLine(), out c))
                Console.Write("Невірне число. Введіть c ще раз: ");

            Console.WriteLine("\nКоефіцієнти рівняння:");
            Console.WriteLine($"{"a",-10} = {a,12:F3}");
            Console.WriteLine($"{"b",-10} = {b,12:F3}");
            Console.WriteLine($"{"c",-10} = {c,12:F3}");

            Console.WriteLine($"\nРівняння: {a}x² + ({b})x + ({c}) = 0");

            if (a == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nПомилка: це не квадратне рівняння, оскільки a = 0.");
                Console.ResetColor();
            }
            else
            {
                double D = b * b - 4 * a * c;

                Console.WriteLine($"Дискримінант D = {D:F3}");

                if (D > 0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(D)) / (2 * a);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nРезультат: рівняння має два корені.");
                    Console.ResetColor();

                    Console.WriteLine($"{"x1",-10} = {x1,12:F3}");
                    Console.WriteLine($"{"x2",-10} = {x2,12:F3}");
                }
                else if (D == 0)
                {
                    double x1 = -b / (2 * a);

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nРезультат: рівняння має один корінь.");
                    Console.ResetColor();

                    Console.WriteLine($"{"x1",-10} = {x1,12:F3}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nДійсних коренів немає.");
                    Console.ResetColor();
                }
            }
        }
    }
}