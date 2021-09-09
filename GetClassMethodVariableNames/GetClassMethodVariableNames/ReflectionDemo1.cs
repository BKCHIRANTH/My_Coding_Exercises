using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetClassMethodVariableNames
{
   public class ReflectionDemo1
    {
        public double volume;
        public string shape;


        public void myMethod1()
        {
            Console.WriteLine("Volume");
        }
        public int myMethod2()
        {
            return 3;
        }

        public string getThisClassName()
        {
            return this.GetType().Name;
        }
    }
}
