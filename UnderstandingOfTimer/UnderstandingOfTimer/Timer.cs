using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace UnderstandingOfTimer
{
  public class Timer
    {
        public System.Timers.Timer aTimer;
        public bool SetTimer(double time)
        {
            
            if (time <= 0)
            {
                Console.WriteLine("Time cannot be <= zero!");
                return false;
            }
            
                aTimer = new System.Timers.Timer(time);   //create timer

                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
                return true;
            
        }

        public void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Welcome!!");

        }
    }
}
