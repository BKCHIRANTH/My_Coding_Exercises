using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfiniteLoop
{
    public class LoopInfinite
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key");
            Console.ReadKey();
            LoopInfinite loop = new LoopInfinite();
            loop.LoopStart();
            
        }
        public void LoopStart()
        {
            //for(; ; )
            for(int i = 1; i >= 1; i++) 
            {
                Console.WriteLine("Infinite Looping!");
            }
        }
    }
}
