using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloadOverride
{
    class OverloadOverrideCall
    {
        static void Main(string[] args)
        {
            OverloadingDemo overloaddemo = new OverloadingDemo();
            overloaddemo.area();
            overloaddemo.area(5);
            overloaddemo.area(10, 20);

            Console.WriteLine("\n");

            OverridingDemo overridedemo = new OverridingDemo();
            overridedemo.Volume(12);
            overloaddemo.Volume(20);
            Console.ReadLine();
        }
    }
}
