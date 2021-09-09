using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOfTimer
{
   public class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the desired time interval in seconds to print the message:");
            double timeInt = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n");
            Timer time = new Timer();
            time.SetTimer(timeInt*1000);

            Console.ReadLine();    
            time.aTimer.Stop();
            time.aTimer.Dispose();

            Console.WriteLine("Application Terminated!");
            Console.ReadLine();
        }
    }
}
