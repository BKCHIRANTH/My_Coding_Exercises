using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintAge
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter bith Date:");
            int date = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter birth Month:");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter birth Year:");
            int year = Convert.ToInt32(Console.ReadLine());

            FindAge age = new FindAge();
            age.CalculateAge(date, month, year);
            Console.ReadLine();
        }
    }
}
