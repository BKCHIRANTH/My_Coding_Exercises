using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDeduction
{
   public class Call
    {
        
        static void Main(string[] args)
        {
            EventRaise eventRaise = new EventRaise();
            eventRaise.SalaryPaid += EventRaise.PFDeduct; 

            eventRaise.Salary(50000); //Paying the salary
            Console.ReadLine();
        }
       
    }
}
