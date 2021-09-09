using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    public class FibonacciSeries
    {
        int term1 = 0, term2 = 1;
        int term3 = 0;
        int cnt = 0;
        string test = "01";
        static void Main(string[] args)
        {
            int term1 = 0, term2 = 1;
            Console.WriteLine("Enter the desired range of Fibonacci Series");
            int range = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries fibonacci = new FibonacciSeries();
            if (range == 1)
            {
                string returnedStringOne = fibonacci.FibonacciSeriesCalculateOne(range);
                Console.ReadLine();
                Environment.Exit(0);
            }
           else if (range == 2)
            {
                string returnedStringTwo = fibonacci.FibonacciSeriesCalculateTwo(range);
                Console.ReadLine();
                Environment.Exit(0);
            }
            
           else if (range == 0)
            {
                string returnedStringZero = fibonacci.FibonacciSeriesCalculateZero(range);
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                Console.Write(term1 + " " + term2);
                string returnedString = fibonacci.FibonacciSeriesCalculate(range - 2);
            }

           
           
            Console.ReadLine();
        }

       
        public string FibonacciSeriesCalculate(int totalRange)
        {
            
            if (totalRange > 0)
            {
                term3 = term1 + term2;
                term1 = term2;
                term2 = term3;
                Console.Write(" " + term3);
                test = test + term3;
                //series[cnt++] = term3;
                 //cnt++;
                
                FibonacciSeriesCalculate(totalRange - 1);
            }
            //Console.WriteLine("1d array content");
            //Console.WriteLine(" "+test);
            //for (int i = 0; i < cnt ; i++)
            //{
            //    Console.WriteLine(series[i]);
            //}

            if (totalRange <= 0)
            {
                return null;
            }


                return test;
        }

        public string FibonacciSeriesCalculateZero(int totalRange)
        {
            Console.WriteLine("Invalid Input");
            string zeroTerm = " ";
            Console.WriteLine(zeroTerm);
            return zeroTerm;
   
        }
        public string FibonacciSeriesCalculateOne(int totalRange)
        {
            string oneTerm = "0";
            Console.WriteLine(oneTerm);
            return oneTerm;
        }

        public string FibonacciSeriesCalculateTwo(int totalRange)
        {
            string twoTerm = "01";
            Console.WriteLine(twoTerm);
            return twoTerm;
        }

        //public void FibonacciSeriesCalculate(int totalRange)
        //{
        //    int term1 = 0, term2 = 1, term3, count;
        //    if (totalRange > 0)
        //    {
        //        for(int i=2; i<totalRange; ++i)
        //        {
        //            term3 = term1 + term2;
        //            term1 = term2;
        //            term2 = term3;
        //            Console.Write(" " + term3);
        //        }
        //    }
        //}

    }
}
