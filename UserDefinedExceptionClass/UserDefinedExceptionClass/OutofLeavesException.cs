using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionClass
{
    public class OutofLeavesException : Exception
    {
        public OutofLeavesException(string message) : base(message)
        {
            Console.WriteLine("No leaves granted!");
        }
    }
}
