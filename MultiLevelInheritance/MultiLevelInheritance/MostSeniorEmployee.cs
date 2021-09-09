using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
   public class MostSeniorEmployee : SeniorEmployee
    {
        
        public string mostSeniorDept = "Top Management";
        public int exp = 21;
        public void MostSeniorDisplay(string name, int age, string job)
        {
            MostSeniorEmployee mostsenior = new MostSeniorEmployee();
            mostsenior.empName = name;
            mostsenior.empAge = age;
            mostsenior.empJob = job;
            Console.WriteLine("Most Senior Employee Name: {0} and age: {1} ", mostsenior.empName, mostsenior.empAge);
            mostsenior.Duty(mostsenior.empJob);
            mostsenior.ExampleMethod(mostsenior.empName); //Junior class method
            mostsenior.Printdepartment(mostsenior.mostSeniorDept); //senior class method
        }

        public void Experience()
        {
            Console.WriteLine("Most Senior Employee has an experience of {0} yrs", exp);
        }


    }
}
