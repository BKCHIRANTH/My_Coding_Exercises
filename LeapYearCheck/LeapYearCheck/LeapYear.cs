using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearCheck
{
    public class LeapYear
    {
        public bool CheckLeapYear(int year)
        {
            if(!(int.TryParse(year.ToString(), out _)))
            {
                Console.WriteLine("Enter a valid year");
                return false;
            }

            string years = year.ToString();
            if(years.Length != 4)
            {
                Console.WriteLine("Enter a valid year");
                return false;
            }

            if( (year % 4 == 0) && ( year % 100 != 0) || (year % 400 == 0) )
            {
                Console.WriteLine("{0} is a leap year!", year);
                return true;
            }

            Console.WriteLine("{0} is not a leap year!", year);
            return false;
        }
    }
}
