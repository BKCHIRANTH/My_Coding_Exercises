using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMultipleEmployee
{
    class Call
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>() {
                new Employee() { employeeName = "Tony", employeeAge = 32, employeeDept = "Lathe" } ,
                new Employee() { employeeName = "Danny", employeeAge = 28, employeeDept = "Package"  } ,
                new Employee() { employeeName = "Sandy", employeeAge = 41, employeeDept = "Goods"   } ,

            };

            SortEmployee sort = new SortEmployee();
            sort.sortName(employeeList);
            Console.Write("\n");

            sort.sortAge(employeeList);
            Console.Write("\n");

            sort.sortDept(employeeList);

            Console.ReadLine();

        }
    }
}
