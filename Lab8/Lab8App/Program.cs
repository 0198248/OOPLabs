using System;
using Lab8Models;

namespace labs
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            /*
            Схема ієрархії:
            Building
            | --House
            | --Warehouse[sealed]
            */

            Console.WriteLine("Прізвище та ім'я: Пламетюк Денис");
            Console.WriteLine("Група: ІПЗ22");
            Console.WriteLine("Варіант: 23\n");

            House house = new House("Потебні, 56", 126, 5);
            Warehouse warehouse = new Warehouse("Склад 23", 530, 63);

            Console.WriteLine("=== БУДИНОК ===");
            Console.WriteLine($"Базова інформація: {house.GetBaseInfo()}");
            Console.WriteLine($"Повна інформація: {house.GetInfo()}");
            Console.WriteLine($"Площа на одного мешканця: {house.CalculateAreaPerResident():F2} м");
            Console.WriteLine();

            Console.WriteLine("=== СКЛАД ===");
            Console.WriteLine($"Базова інформація: {warehouse.GetBaseInfo()}");
            Console.WriteLine($"Повна інформація: {warehouse.GetInfo()}");
            Console.WriteLine($"Використана площа: {warehouse.CalculateUsedArea():F2} м");
            Console.WriteLine();

            Building building = house;

            Console.WriteLine("=== БАЗОВЕ ПОСИЛАННЯ ===");
            Console.WriteLine($"Інформація через Building: {warehouse.GetBaseInfo()}");
            //Тому що змінна building має тип Building, у якому такого методу немає.
        }
    }
}
