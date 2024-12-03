using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritance.Utils
{
    public class BaseClass
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("Сообщение из базового класса.");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void ShowMessage()
        {
            Console.WriteLine("Сообщение из производного класса (override).");
        }

        public new void NewShowMessage()
        {
            Console.WriteLine("Сообщение из производного класса (new).");
        }
    }
}
