using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    
    public class Call
    {
       
        static void Main(string[] args)
        {
            DelegateDemo demo = new DelegateDemo();
            Number num1 = new Number(demo.Add);
            Number num2 = new Number(demo.Subtract);
            Number num3 = new Number(demo.Multiply);

            num1(20,10);   //Only Addition
            Console.WriteLine("\n");

            Number addAndSub;
            addAndSub = num1 + num2;   //Addition and Subtraction
            addAndSub(30,10);
            Console.WriteLine("\n");

            Number sub;
            sub = num2;
            sub(30,5);    //Only Subtraction
            Console.WriteLine("\n");

            Number allMethods;
            allMethods = num1 + num2 + num3;   //All methods
            allMethods(20,10);

            Console.ReadLine();
        }
    }
}
