using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ExecuteThreadsWithoutPriority
{
    class Call
    {
        static void Main(string[] args)
        {
            ExecuteFourThreads fourThreads = new ExecuteFourThreads();

            Thread t1 = new Thread(new ThreadStart(fourThreads.mythread1));
            t1.Start();
            
            Thread t2 = new Thread(new ThreadStart(fourThreads.mythread2));
            t2.Start();
            
            Thread t3 = new Thread(new ThreadStart(fourThreads.mythread3));
            t3.Start();
            
            Thread t4 = new Thread(new ThreadStart(fourThreads.mythread4));
            t4.Start();
            
            Console.ReadLine();
        }
    }
}
