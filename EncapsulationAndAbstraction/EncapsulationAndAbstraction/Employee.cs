using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndAbstraction
{
   public abstract class Employee
    {
        public abstract int GettingSalary();
        public void NonAbstractMethod()
        {
            Console.WriteLine("Non Abstract Method");
        }
    }
}
