using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveOccurances
{
    class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            String str = Console.ReadLine();
            Console.WriteLine("Enter the character to be omitted:");
            char ch = Convert.ToChar(Console.ReadLine());

            RemoveChars chars = new RemoveChars();
            chars.removeAllOccurances(str, ch);
            Console.ReadLine();
        }
    }
}
