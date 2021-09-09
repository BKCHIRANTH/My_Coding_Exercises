using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateToString
{
    public class Call
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Date:");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            DateToStringFormat.ConvertDateToStringMonthName(year, month, date);
            Console.WriteLine("\n");

            DateToStringFormat.ConvertDateToStringDay(year, month, date);
            Console.WriteLine("\n");

            DateToStringFormat.ConvertDateToStringWithDayTime(year, month, date);
            Console.WriteLine("\n");

            DateToStringFormat.DateNow();

            Console.ReadLine();
        }
    }
}
