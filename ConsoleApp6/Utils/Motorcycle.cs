using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public class Motorcycle : Vehicle
    {
        public string Color;

        public Motorcycle() { }

        public Motorcycle(string model, int year, string color)
        {
            Model = model;
            Year = year;
            Color = color;
        }

        public override void Info()
        {
            Console.WriteLine($"Мотоцикл: {Model} | Год выпуска {Year} | Цвет - {Color}");
        }
    }
}
