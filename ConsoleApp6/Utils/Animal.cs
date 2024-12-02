﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Utils
{
    public class Animal
    {        
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal() { }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {

        }
    }

}
