using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMultipleEmployee
{
   public class SortEmployee
    {
        public String[] sortName(List<Employee> names)
        {
            

            var orderByResult = from s in names
                                orderby s.employeeName    //Sorts by name
                                select s;
            
            String[] result = new String[names.Count];
            int cnt = 0;
            Console.WriteLine("Sorting based on employee Name:");

            foreach (var emp in orderByResult)
            {
                if(emp.employeeName == null)
                {
                    return null;
                }

                Console.WriteLine(emp.employeeName);
                result[cnt++] = emp.employeeName;

            }

            return result;
        }

        public String[] sortAge(List<Employee> names)
        {
            var orderByResult = from s in names
                                orderby s.employeeAge //Sorts by age
                                select s;

            String[] result = new String[names.Count];
            int cnt = 0;
            Console.WriteLine("Sorting based on employee Age:");

            foreach (var emp in orderByResult)
            {
                if (emp.employeeAge <= 10)
                {
                    return null;
                }

                Console.WriteLine(emp.employeeName + ": " + emp.employeeAge);
                result[cnt++] = emp.employeeName;

            }

            return result;
        }

        public String[] sortDept(List<Employee> names)
        {
            var orderByResult = from s in names
                                orderby s.employeeDept //Sorts by department
                                select s;

            String[] result = new String[names.Count];
            int cnt = 0;
            Console.WriteLine("Sorting based on employee department:");

            foreach (var emp in orderByResult)
            {
                if (emp.employeeDept == null)
                {
                    return null;
                }

                Console.WriteLine(emp.employeeName + ": " + emp.employeeDept);
                result[cnt++] = emp.employeeName;

            }

            return result;
        }

    }
}
