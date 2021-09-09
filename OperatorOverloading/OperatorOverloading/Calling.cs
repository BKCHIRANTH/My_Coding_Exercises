using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Calling
    {
        static void Main(string[] args)
        {
            OpOverload opObj1 = new OpOverload(10);
            OpOverload opObj2 = new OpOverload(20);
            OpOverload opObj3 = opObj1 + opObj2;

            Console.WriteLine("Measurement1: {0}", opObj1.feet);
            Console.WriteLine("Measurement2: {0}", opObj2.feet);
            opObj3.GetValue();
            Console.WriteLine("\n");

            OpOverloadString opString1 = new OpOverloadString("ABCD");
            OpOverloadString opString2 = new OpOverloadString("WXYZ");

            Console.WriteLine("String1: {0}", opString1.random);
            Console.WriteLine("String2: {0}", opString2.random);
            OpOverloadString opString3 = opString1 + opString2;
            
            opString3.GetString();
            Console.ReadLine();
        }
    }
}
