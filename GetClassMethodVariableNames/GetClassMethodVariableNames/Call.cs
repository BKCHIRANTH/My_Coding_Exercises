using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Reflection.Emit;


namespace GetClassMethodVariableNames
{
    class Call
    {
        static void Main(string[] args)
        {
            Operations op = new Operations();
            op.getThisClassName();
            Console.Write("\n");

            ReflectionDemo demo = new ReflectionDemo();
            demo.getMethodsName();
            Console.Write("\n");

            demo.getVariables();

            Console.ReadLine();

        }
    }
}
