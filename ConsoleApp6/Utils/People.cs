using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public sealed class People
    {
        public string Name;
        public int Age;
        public int Birthday;
        public string Number;

        public People() { }

        public People(string name, int age, int birthday, string number)
        {
            Name = name;
            Age = age;
            Birthday = birthday;
            Number = number;
        }

        public void Info()
        {
            Console.WriteLine("пу-пу-пу...");
        }
    }


}
