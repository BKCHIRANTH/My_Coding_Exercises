using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
   public class Call
    {
        static void Main(string[] args)
        {
            JuniorEmployee juniorEmp = new JuniorEmployee();
            juniorEmp.juniordisplay("Junior_Employee",28,"Intern");
            juniorEmp.ExampleMethod("Junior Method");
            Console.WriteLine("\n");

            SeniorEmployee seniorEmp = new SeniorEmployee();
            seniorEmp.seniordisplay("Senior_Employee",42,"Manager");
            Console.WriteLine("\n");

            MostSeniorEmployee mostSenior = new MostSeniorEmployee();
            mostSenior.MostSeniorDisplay("Most_Senior", 55, "Director");
            mostSenior.Experience();
            Console.ReadLine();


        }
    }
}
