using System;
using Lab11Models;

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

            int threshold = 28;
            int last = 30;

            string indicatorName = "відвідувачів";

            Console.WriteLine("\nПоказник: відвідуваність музею");
            Console.WriteLine($"Порогове значення: {threshold}");
            Console.WriteLine($"Останнє число: {last}");

            StatusReporter reporter = new StatusReporter(indicatorName);

            ValueHandler? actions = reporter.PrintShort;
            actions += reporter.PrintDetailed;

            ValueHandler extra = value =>
                Console.WriteLine($"Додаткове сповіщення: музей зареєстрував {value} відвідувачів");

            actions += extra;

            Console.WriteLine("\n--- Перший прямий виклик делегата ---");
            actions?.Invoke(threshold);

            actions -= reporter.PrintDetailed;

            Console.WriteLine("\n--- Другий прямий виклик делегата ---");
            actions?.Invoke(threshold);

            ProgressCounter counter = new ProgressCounter();

            counter.ThresholdReached += reporter.PrintShort;
            counter.ThresholdReached += reporter.PrintDetailed;
            counter.ThresholdReached += extra;

            Console.WriteLine("\n--- Перший запуск лічильника: три підписники ---");
            counter.CountTo(last, threshold);

            counter.ThresholdReached -= reporter.PrintDetailed;

            Console.WriteLine("\n--- Другий запуск лічильника: два підписники ---");
            counter.CountTo(last, threshold);

            counter.ThresholdReached -= reporter.PrintShort;
            counter.ThresholdReached -= extra;

            Console.WriteLine("\n--- Третій запуск лічильника: без підписників ---");
            counter.CountTo(last, threshold);

            counter.ThresholdReached += AuditReporter.PrintAudit;

            Console.WriteLine("\n--- Четвертий запуск: статичний метод AuditReporter ---");
            counter.CountTo(last, threshold);

            counter.ThresholdReached -= AuditReporter.PrintAudit;

            Console.WriteLine("\n--- П'ятий запуск: після відписки AuditReporter ---");
            counter.CountTo(last, threshold);

            /*ProgressCounter визначає, коли потрібно викликати подію
            StatusReporter та інші обробники визначають реакцію на цю подію
            Статичний метод сумісний із делегатом, оскільки має відповідну сигнатуру*/
        }
    }
}