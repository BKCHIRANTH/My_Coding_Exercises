using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Inheritance
{
   public class Employee : College
    {
        public string employeeName;
        public int hours;
        public int workHour(int hour)
        {
            Console.WriteLine("Working Hours: " + hour);
            return hour;
        }
    }
}
