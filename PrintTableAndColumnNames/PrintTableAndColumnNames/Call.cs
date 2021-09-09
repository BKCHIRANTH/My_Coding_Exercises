using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTableAndColumnNames
{
    class Call
    {
        static void Main(string[] args)
        {
            PrintTableColumns print = new PrintTableColumns();
            print.getTables("test1");

            Console.ReadLine();
        }
    }
}
