using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperation
{
   public abstract class Calculator : ICalculator
    {
        public static double result;
        public double Add(double op1, double op2)
        {
            result = op1 + op2;
            return result;
        }
        public double Subtract(double op1, double op2)
        {
            result = op1 - op2;
            return result;
        }

        public double Multiply(double op1, double op2)
        {
            result = op1 * op2;
            return result;
        }

        public double Division(double op1, double op2)
        {
            //try
            //{
            //result = op1 / op2;
            //}

            //catch(ArithmeticException e)
            //{
            //    Console.WriteLine("Operand 2 must be a natural no");
            //    double opTwo = Convert.ToInt32(Console.ReadLine());
            //    Division(op1, opTwo);
            //}  
            result = op1 / op2;


                if (op2 == 0)
                {
                //    Console.WriteLine("Operand 2 must be a natural no");
                //    Console.WriteLine("Enter the two operands");
                //    double opOne = Convert.ToInt32(Console.ReadLine());
                //    double opTwo = Convert.ToInt32(Console.ReadLine());
                //    Division(opOne, opTwo);
                return 0;
                }

            return result;
        }

        public abstract double GetResult();
        
    }
}
