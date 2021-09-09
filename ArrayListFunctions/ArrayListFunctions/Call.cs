using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListFunctions
{
    class Call
    {
        static void Main(string[] args)
        {
            ExpandableArray arr = new ExpandableArray();
            arr.add("hello world");
            arr.add("First_Name");
            arr.add("Middle Name");
            arr.add("Last Name");

            arr.set(2, "Not_Middle_Name");

            Console.Write("\n");
            arr.get(3);

            Console.Write("\n");
            arr.print();

            Console.ReadLine();

        }
    }
}
