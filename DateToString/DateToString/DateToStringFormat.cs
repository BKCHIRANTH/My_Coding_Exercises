using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace DateToString
{
   public static class DateToStringFormat
    {
        public static String ConvertDateToStringMonthName(int year, int month, int date)
        {

            if(year.ToString().Length != 4)
            {
                Console.WriteLine("Invalid year");
                return " ";
            }

            
            if((month > 12) || (month < 0))
            {
                Console.WriteLine("Invalid month");
                return " ";
            }

            if ((date > 31) || (date < 0))
            {
                Console.WriteLine("Invalid date");
                return " ";
            }

            DateTime dates = new DateTime(year,month,date);
            Console.WriteLine("\n");
            Console.WriteLine("The date is " + dates.ToString("MMMM dd yyyy") + ".");

            String reqDate = dates.ToString("MMMM dd yyyy");

            return reqDate;
        }


        public static String ConvertDateToStringDay(int year, int month, int date)
        {


            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Invalid year");
                return " ";
            }


            if ((month > 12) || (month < 0))
            {
                Console.WriteLine("Invalid month");
                return " ";
            }

            if ((date > 31) || (date < 0))
            {
                Console.WriteLine("Invalid date");
                return " ";
            }

            DateTime aDate = new DateTime(year, month, date);
            Console.WriteLine("Date with Day format:");
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy"));

            String dates = aDate.ToString("dddd, dd MMMM yyyy");

            return dates;
        }

        public static String DateNow()
        {
            DateTime aDate = DateTime.Now;

            String date = aDate.ToString("dd/MM/yyyy");
            Console.WriteLine("Current Date: {0}", date);
            return date;
        }


        public static String ConvertDateToStringWithDayTime(int year, int month, int date)
        {

            if (year.ToString().Length != 4)
            {
                Console.WriteLine("Invalid year");
                return " ";
            }


            if ((month > 12) || (month < 0))
            {
                Console.WriteLine("Invalid month");
                return " ";
            }

            if ((date > 31) || (date < 0))
            {
                Console.WriteLine("Invalid date");
                return " ";
            }

            DateTime aDate = new DateTime(year, month, date, 15, 24, 16);
            Console.WriteLine("Date with Day and Time format:");
            Console.WriteLine(aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

            String dates = aDate.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            return dates;
        }
    }
}
