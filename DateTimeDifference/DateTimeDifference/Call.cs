using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDifference
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time1 details");
            Console.WriteLine("Enter date");
            int date1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int month1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hour");
            int hour1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            int min1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seconds");
            int sec1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine("Enter time2 details");
            Console.WriteLine("Enter date");
            int date2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int month2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter hour");
            int hour2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter minutes");
            int min2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter seconds");
            int sec2 = Convert.ToInt32(Console.ReadLine());

            DateTimeDifferences diffs = new DateTimeDifferences();
            diffs.DateTimeDifferenceCalculate(date1, month1, year1, hour1, min1, sec1, date2, month2, year2, hour2, min2, sec2);

            Console.ReadLine();
        }
    }
}
