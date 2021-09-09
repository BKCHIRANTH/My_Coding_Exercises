using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionClass
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of leaves");
            int leaves = Convert.ToInt32(Console.ReadLine());

            GrantLeave leave = new GrantLeave();
            leave.GrantingLeaves(leaves);

            Console.ReadLine();
        }
    }
}
