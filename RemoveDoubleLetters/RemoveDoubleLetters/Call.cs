using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDoubleLetters
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            String str = Console.ReadLine();

            RemoveDouble remove = new RemoveDouble();
            remove.removeDoubledLetters(str);

            Console.ReadLine();
        }
    }
}
