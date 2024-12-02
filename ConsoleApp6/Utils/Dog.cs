using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp6.Utils
{
    public class Dog : Animal
    {
        public string Color { get; set; }

        public Dog() { }

        public Dog(string name, int age, string color)
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
            Console.WriteLine("Гав гав гав гав");
        }
    }
}
