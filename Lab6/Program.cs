using System;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Лабораторна робота No6\n");

            Console.WriteLine("Студент: Пламетюк Денис");
            Console.WriteLine("Група: ІПЗ22");
            Console.WriteLine("Варіант: 23\n");

            Trip firstObject = new Trip("Луцьк–Ковель", 22, 55);
            Trip secondObject = new Trip("Пробіжка", 3.2, 40);

            Console.WriteLine("Перший об'єкт:");
            firstObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(),2)} м\n");

            Console.WriteLine("Другий об'єкт:");
            secondObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(), 2)} м\n");

            firstObject.Extend(20);

            Console.WriteLine("Перший об'єкт:");
            firstObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(), 2)} м\n");

            Console.WriteLine("Другий об'єкт не змінився, він є іншим об'єктом");
            secondObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(), 2)} м\n");


            Trip sameObject = firstObject;
            sameObject.Extend(10);

            Console.WriteLine("\nСтан через firstObject:");
            firstObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(), 2)} м\n");

            Console.WriteLine("Стан через sameObject:");
            sameObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(), 2)} м\n");
            //firstObject і sameObject посилаються на один об'єкт у пам'яті. Тому зміна через sameObject також відображається через firstObject
            Console.WriteLine("\nКонтрольний виклик із неправильним значенням:");
            firstObject.Extend(-3);
            firstObject.PrintInfo();
            Console.WriteLine($"Відстань: {Math.Round(firstObject.CalculateDistanceMeters(), 2)} м");
        }
    }

    class Trip
    {
        public string Route;
        public double SpeedMetersPerSecond;
        public int DurationMinutes;

        public Trip(string route, double speedMetersPerSecond, int durationMinutes)
        {
            this.Route = route;
            this.SpeedMetersPerSecond = speedMetersPerSecond;
            this.DurationMinutes = durationMinutes;
        }

        public double CalculateDistanceMeters()
        {
            return SpeedMetersPerSecond * DurationMinutes * 60;
        }

        public void Extend(int minutes)
        {
            if (minutes > 0)
            {
                DurationMinutes += minutes;
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Маршрут: {Route}");
            Console.WriteLine($"Швидкість: {SpeedMetersPerSecond} м/с");
            Console.WriteLine($"Тривалість: {DurationMinutes} хв");
        }
    }
}