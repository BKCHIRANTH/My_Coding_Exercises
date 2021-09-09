using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationAndAbstraction
{
   public class Caller
    {
        static void Main(string[] args)
        {
            Manager manage = new Manager();
            manage.SetSalary(45000);
            manage.Duty();
            manage.GettingSalary();

            Console.WriteLine("\n");
            Developer develop = new Developer();
            develop.SetSalary(30000);
            develop.Duty();
            develop.GettingSalary();
            Console.ReadLine();
        }
    }
}
