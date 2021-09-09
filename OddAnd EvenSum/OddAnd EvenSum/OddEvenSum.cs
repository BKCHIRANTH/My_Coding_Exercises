using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenSum
{
   public class OddEvenSum
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range to calculate Odd and Even sum");
            int rangeTerm = Convert.ToInt32(Console.ReadLine());
            OddEvenSum oddevensum = new OddEvenSum();
            int[] negValue = oddevensum.OddEvenSumCalculate(rangeTerm);
            if (negValue == null)
            {
                Console.WriteLine("Enter a valid range");
                int lineAgain = Convert.ToInt32(Console.ReadLine());
                oddevensum.OddEvenSumCalculate(lineAgain);
            }
            Console.ReadLine();
        }

        public int[] OddEvenSumCalculate(int range)
        {
            int evenSum = 0, oddSum = 0;
            if (range >= 0)
            {
                for (int i = 0; i <= range; i++)
                {
                    if (i % 2 == 0)  //modulo operation to check if it is even
                    {
                        evenSum += i;
                    }
                    else
                    {
                        oddSum += i;
                    }
                }
            }

            else
            {
                return null;
            }
            Console.WriteLine($"Sum of Even Numbers till {range} is {evenSum}");
            Console.WriteLine($"Sum of Odd Numbers till {range} is {oddSum}");

            //copying odd and even sum into an array
            int[] sumOfOddAndEven = new int[] { evenSum, oddSum };
            return sumOfOddAndEven;

            
        }

        public int[] OddEvenSumCalculate(string range)
        {
            throw new NotImplementedException("Cannot pass string");
        }
    }
}
