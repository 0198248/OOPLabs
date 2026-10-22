using System;

namespace labs
{
    class Program
    {
        static void Main()
        {
            // Налаштування кодування для коректного введення та виведення тексту
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            // Виведення назви лабораторної роботи
            Console.WriteLine("Лабораторна робота No1");

            // Введення прізвища та імені студента
            Console.Write("Введіть прізвище та ім’я: ");
            string? name = Console.ReadLine();

            // Введення назви навчальної групи
            Console.Write("Введіть групу: ");
            string? group = Console.ReadLine();

            // Введення номера варіанта
            Console.Write("Введіть номер варіанта: ");
            string? variant = Console.ReadLine();

            // Виведення інформації про виконавця лабораторної роботи
            Console.WriteLine($"\nВиконав: {name}");
            Console.WriteLine($"Група: {group}");
            Console.WriteLine($"Варіант: {variant}\n");

            // Введення значення x
            Console.Write("Введіть x: ");
            double x;

            // Перевірка правильності введення числа x
            // Якщо введено не число, програма просить повторити введення
            while (!double.TryParse(Console.ReadLine(), out x))
                Console.Write("\nНевірно введене число, спробуйте ще раз: ");

            // Введення значення z
            Console.Write("Введіть z: ");
            double z;

            // Перевірка правильності введення числа z
            // Цикл повторюється, доки користувач не введе коректне число
            while (!double.TryParse(Console.ReadLine(), out z))
                Console.Write("\nНевірно введене число, спробуйте ще раз: ");

            // Обчислення y:
            double y = Math.Max(Math.Abs(x), Math.Abs(z)) + Math.Min(x, z);

            // Виведення введених значень x і z
            Console.WriteLine($"Для x({x}) і z({z})");

            // Виведення результату обчислення y
            Console.WriteLine($"y = {Math.Round(y, 4)}");
        }
    }
}