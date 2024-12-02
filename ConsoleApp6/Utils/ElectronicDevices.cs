using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    /// <summary>
    /// Пример иерархии классов
    /// </summary>


    
    public class ElectronicDevices
    {
        public string Type;
        public int Id;
        public int Year;

        public ElectronicDevices() { }

        public ElectronicDevices(string type, int id, int year)
        {
            Type = type;
            Id = id;
            Year = year;
        }
    }

    public class Calculator : ElectronicDevices
    {
        public string Color;

        public Calculator() { }

        public Calculator(string type, int id, int year, string color)
        {
            Type = type;
            Id = id;
            Year = year;
            Color = color;
        }
    }

    public class Computer : Calculator
    {
        public int QuantityCores;

        public Computer() { }

        public Computer(string type, int id, int year, string color, int quantityCores)
        {
            Type = type;
            Id = id;
            Year = year;
            Color = color;
            QuantityCores = quantityCores;
        }
    }
}
