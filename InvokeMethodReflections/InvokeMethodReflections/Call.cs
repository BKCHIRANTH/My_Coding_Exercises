using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace InvokeMethodReflections
{
    class Call
    {
        static void Main(string[] args)
        {
            StudentFunc func = new StudentFunc();
            func.operation("22", "Jenny");

            Console.ReadLine();
        }
    }
}
