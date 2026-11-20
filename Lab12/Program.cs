using Lab12;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            int P = 23;
            int limit = 120 + 5 * P;

            Console.WriteLine("Студент: Пламетюк Денис");
            Console.WriteLine("Група: ІПЗ22");
            Console.WriteLine($"Варіант: {P}");
            Console.WriteLine("Тип даних: C — книги");
            Console.WriteLine($"Порогове значення: {limit} сторінок");

            List<BookEntry> books = new List<BookEntry>
            {
                new BookEntry("C-23-1", "Кобзар", 235),
                new BookEntry("C-23-2", "Тигролови", 320),
                new BookEntry("C-23-3", "Місто", 280),
                new BookEntry("C-23-4", "Захар Беркут", 280),
                new BookEntry("C-23-5", "1984", 250),
                new BookEntry("C-23-6", "Маленький принц", 96),
                new BookEntry("C-23-7", "Фарбований Лис", 120),
                new BookEntry("C-23-8", "Лісова пісня", 180)
            };

            Console.WriteLine("\n--- Початковий список книг ---");

            foreach (BookEntry book in books)
            {
                Console.WriteLine($"{book.Code} | {book.Title} | {book.PageCount} стор.");
            }

            IEnumerable<String> methodQuery = books
                .Where(book => book.PageCount >= limit)
                .OrderByDescending(book => book.PageCount)
                .ThenBy(book => book.Title)
                .Select(book => $"{book.Code} | {book.Title} | {book.PageCount} стор.");

            Console.WriteLine("\n--- Основний запит: синтаксис методів ---");

            foreach (string book in methodQuery)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\n--- Перші три книги після сортування ---");

            foreach (string book in methodQuery.Take(3))
            {
                Console.WriteLine(book);
            }

            int count = books.Count(book => book.PageCount >= limit);
            int max = books.Max(book => book.PageCount);

            Console.WriteLine("\n--- Підрахунок і пошук ---");
            Console.WriteLine($"Кількість книг із {limit} або більше сторінками: {count}");
            Console.WriteLine($"Найбільша кількість сторінок: {max}");

            string existingCode = "C-23-3";
            string missingCode = "C-23-99";

            BookEntry? foundBook = books.FirstOrDefault(book => book.Code == existingCode);

            if (foundBook != null)
            {
                Console.WriteLine($"Знайдено книгу: {foundBook.Code} | {foundBook.Title}");
            }
            else
            {
                Console.WriteLine($"Книгу з кодом {existingCode} не знайдено");
            }

            BookEntry? missingBook = books.FirstOrDefault(book => book.Code == missingCode);

            if (missingBook != null)
            {
                Console.WriteLine($"Знайдено книгу: {missingBook.Code} | {missingBook.Title}");
            }
            else
            {
                Console.WriteLine($"Книгу з кодом {missingCode} не знайдено");
            }

            IEnumerable<String> querySyntax =
                from book in books
                where book.PageCount >= limit
                orderby book.PageCount descending, book.Title ascending
                select $"{book.Code} | {book.Title} | {book.PageCount} стор.";

            Console.WriteLine("\n--- Основний запит: синтаксис LINQ-запиту ---");

            foreach (string book in querySyntax)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("\n--- Порівняння двох запитів ---");

            Console.WriteLine(
                $"Результати однакові: {methodQuery.SequenceEqual(querySyntax)}"
            );

            Console.WriteLine("\n--- Дослід із моментом виконання LINQ ---");

            List<int> numbers = new List<int> { 1, 2, 3 };

            IEnumerable<int> numberQuery = numbers.Where(number => number >= 2);

            numbers.Add(4);

            Console.WriteLine("Результат запиту після додавання 4:");

            foreach (int number in numberQuery)
            {
                Console.WriteLine(number);
            }

            List<int> savedNumbers = numberQuery.ToList();

            numbers.Add(5);

            Console.WriteLine("\nЗбережений список після додавання 5:");

            foreach (int number in savedNumbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\nПовторний перебір початкового запиту:");

            foreach (int number in numberQuery)
            {
                Console.WriteLine(number);
            }

            /*LINQ дозволяє відбирати, сортувати та перетворювати дані
            Where, OrderByDescending, ThenBy і Select формують запит
            Count, Max і FirstOrDefault дозволяють отримувати інформацію про дані
            Take(3) повертає перші три записи вже відсортованої послідовності
            LINQ-запит виконується під час перебору, а ToList() зберігає результат на момент виклику*/
        }
    }
}