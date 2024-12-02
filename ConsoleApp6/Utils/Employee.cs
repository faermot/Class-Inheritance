using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public class Employee
    {
        public string Name;
        public int Salary;

        public Employee() { }

        public Employee(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public virtual void Info() { }
    }

    public class Manager : Employee
    {
        string Number;
        string Currency;
        public Manager() { }

        public Manager(string name, int salary, string currency, string number)
        {
            Name = name;
            Salary = salary;
            Number = number;
            Currency = currency;
        }
        public override void Info()
        {
            Console.WriteLine($"Менеджер {Name} | Зарплата - {Salary} {Currency} | {Number}");
        }
    }

    public class Developer : Employee
    {
        string Number;
        string Currency;
        string Post;
        public Developer() { }

        public Developer(string name, int salary, string currency, string number, string post)
        {
            Name = name;
            Salary = salary;
            Number = number;
            Currency = currency;
            Post = post;
        }
        public override void Info()
        {
            Console.WriteLine($"Разработчик '{Post}' {Name} | Зарплата - {Salary} {Currency} | {Number}");
        }
    }
}
