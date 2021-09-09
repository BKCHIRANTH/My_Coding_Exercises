using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TwoThreadsHandling
{
   public class TwoThreads
    {
        public void myThread1(object terms)
        {
            Console.WriteLine("Multiples of 5:");
            for(int i = 1; i <= (int)terms; i++)
            {
                Console.WriteLine(5 * i);
            }
        }

        public void myThread2(object terms)
        {
            Console.WriteLine("Multiples of 100:");
            for (int i = 1; i <= (int)terms; i++)
            {
                Console.WriteLine(100 * i);
            }
        }
    }
}
