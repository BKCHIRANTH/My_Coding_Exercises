using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchEmployeeTableSQL
{
    class Call
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getEmpDetails("employeeDetails");

            Console.ReadLine();
        }
    }
}
