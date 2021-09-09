using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace ThreadSleepConcept
{
    class Call
    {
        static void Main(string[] args)
        {
            ThreadSleep threadObj = new ThreadSleep();
            
            Thread t1 = new Thread(new ThreadStart(threadObj.myThread1));
            t1.Start();


            Thread t2 = new Thread(new ThreadStart(threadObj.myThread2));
            t2.Start();


            Thread t3 = new Thread(new ThreadStart(threadObj.myThread3));
            t3.Start();


            Console.ReadLine();
            t1.Abort();
            t2.Abort();
            t3.Abort();

        }
    }
}
