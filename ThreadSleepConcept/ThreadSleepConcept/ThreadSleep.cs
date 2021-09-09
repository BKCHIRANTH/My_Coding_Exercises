using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace ThreadSleepConcept
{
   public class ThreadSleep
    {
        
        public void myThread1()
        {
                Console.WriteLine("Good Morning");
                Thread.Sleep(1000);
                 myThread1();
        }

        public void myThread2()
        {
                Console.WriteLine("Hello");
                Thread.Sleep(5000);
                myThread2();
        }

        public void myThread3()
        {
                Console.WriteLine("Welcome");
                Thread.Sleep(6000);
                myThread3();
        }
        
    }
}
