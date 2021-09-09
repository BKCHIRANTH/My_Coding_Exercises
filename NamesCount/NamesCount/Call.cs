using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesCount
{
    class Call
    {
        static void Main(string[] args)
        {
            List<String> names = new List<String>();
            String input = "";
            Console.WriteLine("Enter the names");
            input = Console.ReadLine();
            names.Add(input);

            while (input != "")
            {
                input = Console.ReadLine();
                names.Add(input);

            }

            CountingNames namescount = new CountingNames();
            namescount.getCounts(names);

            Console.ReadLine();
        }
    }
}
