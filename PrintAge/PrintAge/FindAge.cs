using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAge
{
   public class FindAge
    {
        public string[] CalculateAge(int dates, int month, int year)
        {
            if(!(int.TryParse(dates.ToString(),out _)))
            {
                Console.WriteLine("Enter valid date");
                return null;
            }

            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Invalid year");
                return null;
            }

            if ((month > 12) || (month < 0))
            {
                Console.WriteLine("Invalid month");
                return null;
            }

            if ((dates > 31) || (dates < 0))
            {
                Console.WriteLine("Invalid date");
                return null;
            }


            DateTime date = DateTime.Now;

            DateTime BirthDate = new DateTime(year, month, dates);
            TimeSpan diff = date.Subtract(BirthDate);

            string TotalDays = diff.Days.ToString();

            string Months = ((diff.Days) % 365).ToString();
            string RemainingMonths = (Convert.ToInt32(Months) / 31).ToString();
            string RemainingYears = ((diff.Days) / 365).ToString();
            string RemainingWeeks = ((diff.Days) / 7).ToString();
            string RemainingDays = (Convert.ToInt32(Months) % 31).ToString();

            string[] resultAge = new string[4] { RemainingDays, RemainingWeeks, RemainingMonths, RemainingYears };

            Console.Write("\n");
            Console.WriteLine("She/He is {0} days, {1} weeks and {2} months old!", RemainingDays, RemainingWeeks, RemainingMonths);
            Console.WriteLine("Her/His age is {0} years", RemainingYears);

            return resultAge;
        }
    }
}
