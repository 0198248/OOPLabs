using System;
using Lab9Models;

namespace labs
{
    class program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Студент: Пламетюк Денис");
            Console.WriteLine("Група: ІПЗ22");
            Console.WriteLine("Варіант: 23");

            Console.WriteLine("\nІєрархія класів:");
            Console.WriteLine("ICalculable");
            Console.WriteLine("    Transport (abstract)");
            Console.WriteLine("        Car");
            Console.WriteLine("        Bus");
            Console.WriteLine("        Train");

            Transport car = new Car("Car-23", 215, 93, 33);
            Transport bus = new Bus("Bus-23", 172, 68, 12);
            Transport train = new Train("Train-23", 219, 103, 43);

            Transport[] transports = { car, bus, train };

            Console.WriteLine("\nІнформація про транспорт:");

            foreach (Transport transport in transports)
            {
                Console.WriteLine(transport.GetDescription());
                Console.WriteLine($"Тривалість поїздки: {transport.CalculateMetric():F3} год");
                Console.WriteLine();
            }

            ICalculable[] calculableTransports = { car, bus, train };

            Console.WriteLine("Обчислення через інтерфейс:");

            foreach (ICalculable item in calculableTransports)
            {
                Console.WriteLine($"Тривалість поїздки: {item.CalculateMetric():F3} год");
            }

            Console.WriteLine("\nПеревірка ручним обчисленням:");
            Console.WriteLine($"Автомобіль: 215 / 93 + 33 / 60 = {215.0 / 93 + 33.0 / 60:F3} год");
            Console.WriteLine($"Автобус: 172 / 68 + 12 * 3 / 60 = {172.0 / 68 + 12.0 * 3 / 60:F3} год");
            Console.WriteLine($"Потяг: 219 / 103 * (1 + 43 / 100) = {219.0 / 103 * (1 + 43.0 / 100):F3} год");
        }
    }
}