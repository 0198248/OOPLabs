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

            Console.WriteLine("Лабораторна робота No4");

            Console.Write("Введіть текст: ");
            string? text = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(text))
            {
                Console.Write("Поле не може бути пустим, введіть текст знову: ");
                text = Console.ReadLine();
            }

            string originalText = text;

            Console.WriteLine($"Початковий текст: {text}");
            Console.WriteLine($"Довжина тексту: {text.Length}");
            Console.WriteLine($"Перший символ: {text[0]}, індекс: 0");
            Console.WriteLine($"Останній символ: {text[text.Length - 1]}, індекс: {text.Length - 1}");

            int letters = 0;
            int digits = 0;
            int spaces = 0;
            int punctuation = 0;
            int upper = 0;
            int lower = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (char.IsLetter(c))
                    letters++;

                if (char.IsDigit(c))
                    digits++;

                if (char.IsWhiteSpace(c))
                    spaces++;

                if (char.IsPunctuation(c))
                    punctuation++;

                if (char.IsUpper(c))
                    upper++;

                if (char.IsLower(c))
                    lower++;
            }

            Console.WriteLine($"Кількість літер: {letters}");
            Console.WriteLine($"Кількість цифр: {digits}");
            Console.WriteLine($"Кількість пробільних символів: {spaces}");
            Console.WriteLine($"Кількість розділових знаків: {punctuation}");
            Console.WriteLine($"Кількість великих літер: {upper}");
            Console.WriteLine($"Кількість малих літер: {lower}");

            string[] words = text.Split(
                new char[] { ' ', '\t', '\n' },
                StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Кількість слів: {words.Length}");

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"Слово {i + 1}: {words[i]}, довжина: {words[i].Length}");
            }

            if (words.Length == 0)
            {
                Console.WriteLine("Слів у тексті не знайдено.");
                return;
            }

            string longestWord = words[0];
            int longestWordNumber = 1;

            for (int i = 1; i < words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                    longestWordNumber = i + 1;
                }
            }

            StringBuilder result = new StringBuilder();

            result.Append(longestWord);

            Console.WriteLine("\nРезультат перетворення:");
            Console.WriteLine($"Початковий текст: {originalText}");
            Console.WriteLine($"Перетворений текст: {result}");
            Console.WriteLine($"Найдовше слово: {longestWord}");
            Console.WriteLine($"Довжина слова: {longestWord.Length}");
            Console.WriteLine($"Порядковий номер слова: {longestWordNumber}");
        }
    }
}