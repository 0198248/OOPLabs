using System;
using System.Collections.Generic;
using Lab10Models;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Студент: Пламетюк Денис");
            Console.WriteLine("Група: ІПЗ22");
            Console.WriteLine("Варіант: 23");
            Console.WriteLine("Тип даних: Книги (BookEntry)");

            BookEntry book1 = new BookEntry(
                "C-23-1", "Кобзар", "Тарас Шевченко", 235, 1840);

            BookEntry book2 = new BookEntry(
                "C-23-2", "Тигролови", "Іван Багряний", 320, 1944);

            BookEntry book3 = new BookEntry(
                "C-23-3", "1984", "Джордж Орвелл", 328, 1949);

            Console.WriteLine("\nПочаткові записи:");

            Console.WriteLine(book1.GetInfo());
            Console.WriteLine(book2.GetInfo());
            Console.WriteLine(book3.GetInfo());

            Catalog<BookEntry> catalog = new Catalog<BookEntry>();

            catalog.Add(book1);
            catalog.Add(book2);
            catalog.Add(book3);

            Console.WriteLine("\nРОБОТА З КАТАЛОГОМ");

            Console.WriteLine($"Кількість записів: {catalog.Count}");

            catalog.PrintAll();

            Console.WriteLine("\nПерший запис:");
            Console.WriteLine(catalog.GetAt(0).GetInfo());

            Console.WriteLine("\nПеревірка ContainsCode:");
            Console.WriteLine($"C-23-2: {catalog.ContainsCode("C-23-2")}");
            Console.WriteLine($"C-23-5: {catalog.ContainsCode("C-23-5")}");

            Console.WriteLine("\nВилучення записів:");

            Console.WriteLine($"Вилучення C-23-2: {catalog.RemoveByCode("C-23-2")}");
            Console.WriteLine($"Вилучення C-23-5: {catalog.RemoveByCode("C-23-5")}");

            Console.WriteLine($"Кількість після вилучення: {catalog.Count}");

            Console.WriteLine("Залишок каталогу:");
            catalog.PrintAll();

            Queue<BookEntry> queue = new Queue<BookEntry>();

            queue.Enqueue(book1);
            queue.Enqueue(book2);
            queue.Enqueue(book3);

            Console.WriteLine("\nРОБОТА З ЧЕРГОЮ");

            Console.WriteLine($"Кількість елементів: {queue.Count}");
            Console.WriteLine($"Перший елемент: {queue.Peek().Code}");

            BookEntry dequeuedBook = queue.Dequeue();

            Console.WriteLine($"Вилучений елемент: {dequeuedBook.Code}");
            Console.WriteLine($"Кількість після вилучення: {queue.Count}");

            Console.WriteLine("Залишок черги:");

            foreach (BookEntry book in queue)
            {
                Console.WriteLine(book.GetInfo());
            }

            Stack<BookEntry> stack = new Stack<BookEntry>();

            stack.Push(book1);
            stack.Push(book2);
            stack.Push(book3);

            Console.WriteLine("\nРОБОТА ЗІ СТЕКОМ");

            Console.WriteLine($"Кількість елементів: {stack.Count}");
            Console.WriteLine($"Верхній елемент: {stack.Peek().Code}");

            BookEntry poppedBook = stack.Pop();

            Console.WriteLine($"Вилучений елемент: {poppedBook.Code}");
            Console.WriteLine($"Кількість після вилучення: {stack.Count}");

            Console.WriteLine("Залишок стека:");

            foreach (BookEntry book in stack)
            {
                Console.WriteLine(book.GetInfo());
            }

            Dictionary<string, BookEntry> dictionary =
                new Dictionary<string, BookEntry>();

            dictionary.Add(book1.Code, book1);
            dictionary.Add(book2.Code, book2);
            dictionary.Add(book3.Code, book3);

            Console.WriteLine("\nРОБОТА ЗІ СЛОВНИКОМ");

            Console.WriteLine($"Кількість записів: {dictionary.Count}");

            Console.WriteLine("\nПошук наявного запису:");

            if (dictionary.TryGetValue("C-23-1", out BookEntry foundBook))
            {
                Console.WriteLine(foundBook.GetInfo());
            }

            Console.WriteLine("\nПошук відсутнього запису:");

            if (dictionary.TryGetValue("C-23-5", out BookEntry missingBook))
            {
                Console.WriteLine(missingBook.GetInfo());
            }
            else
            {
                Console.WriteLine("Запис не знайдено");
            }

            //Каталог зберігає елементи у звичайному списку
            //Черга працює за принципом FIFO
            //Стек працює за принципом LIFO
            //Словник дозволяє знаходити записи за унікальним кодом

        }
    }
}