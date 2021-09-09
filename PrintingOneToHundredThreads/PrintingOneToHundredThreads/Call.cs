using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PrintingOneToHundredThreads
{
    class Call
    {
        static void Main(string[] args)
        {
            PrintNumbers nos = new PrintNumbers();

            Thread thr = new Thread(new ThreadStart(nos.printOneToHundred));

            thr.Start();

            Console.ReadLine();
        }
    }
}
