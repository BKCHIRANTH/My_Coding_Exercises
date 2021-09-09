using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;


namespace GetClassMethodVariableNames
{
   public class Operations
    {
        public int randomVariable;
        public string someString;

        
        public void myMethod1()
        {
            Console.WriteLine("Hello world");
        }
        public int myMethod2()
        {
            return 3;
        }
        
        public string getThisClassName()
        {
            Console.WriteLine("Class Name:");
            Console.WriteLine(this.GetType().Name);
            return this.GetType().Name;
        }
        
    }
}
