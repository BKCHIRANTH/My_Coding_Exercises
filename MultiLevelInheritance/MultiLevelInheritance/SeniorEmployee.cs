using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    public class SeniorEmployee : JuniorEmployee
    {
        
        public string department;
        string[] seniorDetails = new string[10];
        public string[] seniordisplay(string name, int age, string job)
        {
            SeniorEmployee senior = new SeniorEmployee();
            senior.empName = name;
            senior.empAge = age;
            senior.empJob = job;
            Console.WriteLine("Senior Employee Name: {0} and age: {1} ", senior.empName, senior.empAge);

            senior.Duty(senior.empJob); //Base class method
            senior.ExampleMethod(senior.empName); //Junior Class Method

            seniorDetails[0] = senior.empName;
            seniorDetails[1] = senior.empAge.ToString();
            seniorDetails[2] = senior.empJob;
            return seniorDetails;
        }
        public string Printdepartment(string dept)
        {
            //method available to senior employee and most senior employee only
            Console.WriteLine("The employee works in the dept of: {0}", dept);
            return dept;
        }
    }
}
