using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public class Vehicle
    {
        public string Model = "a";
        public int Year = 2020;

        public Vehicle() { }

        public Vehicle(string model, int year)
        {
            Model = model;
            Year = year;
        }

        public virtual void Info()
        {
            Console.WriteLine($"{Model} | {Year} ");
        }
    }
}
