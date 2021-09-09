using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OddOrEven
{
    public class OddEven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            double num = Convert.ToDouble(Console.ReadLine());
            OddEven oddeven = new OddEven();
            bool result = oddeven.OddOrEvenCheck(num);
            if(result == true)
            {
                Console.WriteLine($"{num} is an even number");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number");
            }
            Console.ReadLine();
           
        }

        public bool OddOrEvenCheck(double number)
        {
            
            if (number % 2 == 0)
            {
                return true;
            }

                return false;
        }

        public object OddOrEvenCheck(string test)
        {
            throw new NotImplementedException("Cannot pass string");
        }
    }

}
