using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndAbstraction
{
   public class Manager : Employee , IEmployee
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
            Console.WriteLine("Manager Position");
        }
        public override int GettingSalary()
        {
            //abstarct method
            Console.WriteLine("Salary of a Manager: " + this.salary);
            return this.salary;
        }

        
    }
}
