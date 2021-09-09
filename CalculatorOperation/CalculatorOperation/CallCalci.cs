using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperation
{
    public class CallCalci : Calculator
    {
       
        public override double GetResult()
        {
            Console.WriteLine("Result: {0}", result);
            return result;
        }

        
        static void Main(string[] args)
        {
            CallCalci cal = new CallCalci();
            int choice;
            while (true)
            {
                Console.WriteLine("Calculator Operations: 1.Addition 2.Subtraction 3.Multiplication 4.Division");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Console.WriteLine("Enter the two operands");
                            double op1 = Convert.ToInt32(Console.ReadLine());
                            double op2 = Convert.ToInt32(Console.ReadLine());
                            cal.Add(op1, op2);
                            cal.GetResult();
                            break;

                    case 2:
                            Console.WriteLine("Enter the two operands");
                            double op3 = Convert.ToInt32(Console.ReadLine());
                            double op4 = Convert.ToInt32(Console.ReadLine());
                            cal.Subtract(op3, op4);
                            cal.GetResult();
                            break;

                    case 3:
                            Console.WriteLine("Enter the two operands");
                            double op5 = Convert.ToInt32(Console.ReadLine());
                            double op6 = Convert.ToInt32(Console.ReadLine());
                            cal.Multiply(op5, op6);
                            cal.GetResult();
                            break;

                    case 4:
                            Console.WriteLine("Enter the two operands");
                            double op7 = Convert.ToInt32(Console.ReadLine());
                            double op8 = Convert.ToInt32(Console.ReadLine());
                            cal.Division(op7, op8);
                            cal.GetResult();
                            break;

                    default:Environment.Exit(0);
                            break;

                }
                Console.ReadLine();
            }
        }
    }
}
