using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public class Car : Vehicle
    {
        public int quantityDoors;

        public Car() { }

        public Car(string model, int year, int quantity_doors)
        {
            Model = model;
            Year = year;
            quantityDoors = quantity_doors;
        }

        public override void Info()
        {
            Console.WriteLine($"Автомобиль: {Model} | Год выпуска {Year} | Количество дверей - {quantityDoors}");
            Console.WriteLine("------------");
            base.Info();
            Console.WriteLine("------------");
        }
    }
}
