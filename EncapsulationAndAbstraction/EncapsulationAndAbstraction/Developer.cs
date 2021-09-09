using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndAbstraction
{
    public class Developer : Employee , IEmployee
    {
       private int salary;

        public void SetSalary(int sal)
        {
            this.salary = sal;

        }
        public int GetSalary()
        {
            return this.salary;
        }

       public void Duty()
        {
            //interface method
            Console.WriteLine("Developer Position");
        }
        public override int GettingSalary()
        {
            Console.WriteLine("Salary of a Developer: " + this.salary);
            return this.salary;
        }
    }
}
