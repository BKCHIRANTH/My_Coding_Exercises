using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class Call
    {
        static void Main(string[] args)
        {
            ExceptionHandle handle = new ExceptionHandle();
            handle.Divideby(10, 10);
            
            Console.ReadLine();
        }
    }
}
