using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationVirtual
{
    public class Multiplication : CalciOperations
    {
        public override double CalculatorOperations(double op1, double op2)
        {
            Console.WriteLine("Product= {0}", op1 * op2);
            return op1 * op2;

        }
    }
}
