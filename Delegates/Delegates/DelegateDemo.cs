using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate int Number(int a, int b);
    public class DelegateDemo
    {
       
        public int Add(int param1, int param2)
        {
            int param = 0;
            param = param1 + param2;
            Console.WriteLine("Addition= {0}", param);
            return param;
        }
        public int Subtract(int param1, int param2)
        {
            int param = 0;
            param = param1 - param2;
            Console.WriteLine("Subtraction= {0}", param);
            return param;
        }
        public int Multiply(int param1, int param2)
        {
            int param = 0;
            param = param1 * param2;
            Console.WriteLine("Multiplication= {0}", param);
            return param;
        }


    }
}
