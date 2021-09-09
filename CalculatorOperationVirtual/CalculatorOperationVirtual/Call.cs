using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperationVirtual
{
    public class Call
    {
        static void Main(string[] args)
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Calculator Operations: 1.Addition 2.Subtraction 3.Multiplication 4.Division");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Addition add = new Addition();
                        Console.WriteLine("Enter the two operands");
                        double op1 = Convert.ToInt32(Console.ReadLine());
                        double op2 = Convert.ToInt32(Console.ReadLine());
                        add.CalculatorOperations(op1, op2);
                        break;

                    case 2:
                        Subtraction sub = new Subtraction();
                        Console.WriteLine("Enter the two operands");
                        double op3 = Convert.ToInt32(Console.ReadLine());
                        double op4 = Convert.ToInt32(Console.ReadLine());
                        sub.CalculatorOperations(op3, op4);
                        break;

                    case 3:
                        Multiplication mul = new Multiplication();
                        Console.WriteLine("Enter the two operands");
                        double op5 = Convert.ToInt32(Console.ReadLine());
                        double op6 = Convert.ToInt32(Console.ReadLine());
                        mul.CalculatorOperations(op5, op6);
                        break;

                    case 4:
                        Division div = new Division();
                        Console.WriteLine("Enter the two operands");
                        double op7 = Convert.ToInt32(Console.ReadLine());
                        double op8 = Convert.ToInt32(Console.ReadLine());
                        div.CalculatorOperations(op7, op8);
                        break;

                    default:
                        Environment.Exit(0);
                        break;

                }
                Console.ReadLine();
            }
        }
    }
}
