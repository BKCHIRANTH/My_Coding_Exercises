using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndSpecificExceptions
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two inputs to divide");
            double inp1 = Convert.ToDouble(Console.ReadLine());
            double inp2 = Convert.ToDouble(Console.ReadLine());
            Division div = new Division();
            div.Divide(inp1, inp2);

            Console.ReadLine();
        }
    }
}
