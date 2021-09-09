using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
   public class Employee
    {
        public string empName;
        public int empAge;
        public string empJob;
        public void Duty(string job)
        {
            Console.WriteLine("The job assigned: " + empJob);
        }

        
    }
}
