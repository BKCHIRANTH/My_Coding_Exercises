using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class OpOverload
    {
        public int feet;
        public string random;

        public OpOverload()
        {

        }
        public OpOverload(int i)
        {
            this.feet = i;
        }

        public static OpOverload operator +(OpOverload op1, OpOverload op2)
        {
            OpOverload temp = new OpOverload();
            temp.feet = op1.feet + op2.feet;
            return temp;
        }

        public int GetValue()
        {
            Console.WriteLine("Total Measurement: {0}", feet);
            return feet;
            
        }
    }
}
