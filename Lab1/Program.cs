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
        }
    }
}