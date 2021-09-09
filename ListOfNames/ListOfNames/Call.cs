using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames
{
    class Call
    {
        static void Main(string[] args)
        {
            List<String> names = new List<string>();
            String input="";
            Console.WriteLine("Enter the names");
            input = Console.ReadLine();
            names.Add(input);

            while (input!="")
            {
                input = Console.ReadLine();
                names.Add(input);

            }

            NamesList namelist = new NamesList();
            namelist.removeDuplicate(names);

            Console.ReadLine();
        }
    }
}
