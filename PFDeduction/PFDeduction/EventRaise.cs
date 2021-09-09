using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFDeduction
{
    public delegate void Notify();  // delegate
    public class EventRaise
    {
        public event Notify SalaryPaid; // event
        public static double empSalary;
        public double Salary(double salary)
        {
            empSalary = empSalary + salary;
            Console.WriteLine("Salary Received: {0}", salary);
            Console.WriteLine("Salary Before PF Deduction: {0}", empSalary);
            OnSalaryPaid();   //after salary is paid
            return empSalary;
        }


        private void OnSalaryPaid()
        {
            SalaryPaid?.Invoke();
        }

        public static void PFDeduct()
        {

            EventRaise.empSalary = EventRaise.empSalary - (EventRaise.empSalary * 0.1);
            Console.WriteLine("\n");
            Console.WriteLine("PF Deducted!");
            Console.WriteLine("Salary after PF Deduction: {0}", EventRaise.empSalary);

        }
    }
}
