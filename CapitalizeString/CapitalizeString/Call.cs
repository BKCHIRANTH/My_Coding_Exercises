using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeString
{
    class Call
    {
        static void Main(string[] args)
        {
            Capitalize capital = new Capitalize();

            Console.WriteLine("Enter your name please");
            String name = Console.ReadLine();

            capital.CapitalizeName(name);
            Console.ReadLine();
        }
    }
}
