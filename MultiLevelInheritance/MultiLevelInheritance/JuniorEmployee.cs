using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
   public class JuniorEmployee : Employee
    {
        
        string[] juniorDetails = new string[10];
       public string[] juniordisplay(string name, int age, string job)
        {
            JuniorEmployee junior = new JuniorEmployee();
            junior.empName = name;
            junior.empAge = age;
            junior.empJob = job;
            Console.WriteLine("Junior Employee Name: {0} and age: {1} ", junior.empName, junior.empAge);
            junior.Duty(junior.empJob);

            juniorDetails[0] = junior.empName;
            juniorDetails[1] = junior.empAge.ToString();
            juniorDetails[2] = junior.empJob;
            return juniorDetails;

        }
        
        public string ExampleMethod(string name)
        {
            //method available for subclasses
            Console.WriteLine("Hello {0}!", name);
            return name;
        }
    }
}
