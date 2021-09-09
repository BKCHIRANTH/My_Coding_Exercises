using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLineByLine
{
    public class Call
    {
        static void Main(string[] args)
        
{
            Console.WriteLine("Enter the comma seperated names");
            String names = Console.ReadLine();

            LineByLine line = new LineByLine();
            line.PrintLineByLine(names);
            Console.ReadLine();
        }
    }
}
