using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOperation
{
    interface ICalculator
    {
        double Add(double op1, double op2);
        double Subtract(double op1, double op2);
        double Multiply(double op1, double op2);
        double Division(double op1, double op2);
    }
}
