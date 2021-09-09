using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationVirtual
{
    public class Division : CalciOperations
    {
        public override double CalculatorOperations(double op1, double op2)
        {
            //double div;
            //try
            //{
            //    //Console.WriteLine("Quotient= {0}", op1 / op2);
            //     div = op1 / op2;
            //}
            //catch(DivideByZeroException )
            //{
            //    Console.WriteLine("Operand 2 cannot be zero");
            //    return 0;
            //}

            if(op2 == 0)
            {
                return 0;
            }
            Console.WriteLine("Quotient= {0}", op1 / op2);
            return op1 / op2;

        }
    }
}
