using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCheck
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year:");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            LeapYear leap = new LeapYear();
            leap.CheckLeapYear(year);

            Console.ReadLine();

        }
    }
}
