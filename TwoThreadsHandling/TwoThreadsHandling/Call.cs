using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TwoThreadsHandling
{
    class Call
    {
        static void Main(string[] args)
        {
            TwoThreads thrObj = new TwoThreads();

            
            Thread t1 = new Thread(thrObj.myThread1);
            t1.Start(5);

            Thread t2 = new Thread(thrObj.myThread2);
            Thread.Sleep(1000);
            t2.Start(6);
            
            Console.ReadLine();
            t1.Abort();
            t2.Abort();
        }
    }
}
