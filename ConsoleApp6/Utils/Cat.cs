using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public class Cat : Animal
    {
        public string Color { get; set; }

        public Cat() { }

        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }


        public void Info()
        {
            Console.WriteLine($"Имя - {Name}, Возраст - {Age}, Цвет - {Color}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Мяу мяу мяу мяу");
        }
    }
}
