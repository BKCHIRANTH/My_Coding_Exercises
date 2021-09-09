using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDifference
{
    public class DateTimeDifferences
    {
        public int[] DateTimeDifferenceCalculate(int date1, int month1, int year1, int hour1, int min1, int sec1, int date2, int month2, int year2, int hour2, int min2, int sec2)
        {

            if(!int.TryParse(date1.ToString(), out _))
            {
                Console.WriteLine("No special chars allowed");
                return null;
            }

            if ((year1.ToString().Length != 4) || (year2.ToString().Length != 4))
            {
                Console.WriteLine("Invalid year");
                return null;
            }

            if ((month1 > 12) || (month1 < 0) || (month2 > 12) || (month2 < 0))
            {
                Console.WriteLine("Invalid month");
                return null;
            }

            if ((date1 > 31) || (date1 < 0) || (date2 > 31) || (date2 < 0))
            {
                Console.WriteLine("Invalid date");
                return null;
            }

            DateTime time1 = new DateTime(year1, month1, date1, hour1, min1, sec1);
            DateTime time2 = new DateTime(year2, month2, date2, hour2, min2, sec2);
            TimeSpan timediff = time2.Subtract(time1);

            int[] diff = new int[4] { timediff.Days, timediff.Hours, timediff.Minutes, timediff.Seconds };
           
            Console.Write("\n");
            Console.WriteLine("Time Difference: {0} days {1} hours {2} minutes and {3} seconds", timediff.Days, timediff.Hours, timediff.Minutes, timediff.Seconds);


            return diff;
        }
    }
}
