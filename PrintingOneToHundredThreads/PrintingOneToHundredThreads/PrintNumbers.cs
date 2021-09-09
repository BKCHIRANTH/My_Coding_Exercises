using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrintingOneToHundredThreads
{
   public class PrintNumbers
    {
        public void printOneToHundred()
        {
            Console.WriteLine("Numbers List");
            Console.Write("\n");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(" "+i);
                
            }
            
            //return true;
        }

        
    }
}
