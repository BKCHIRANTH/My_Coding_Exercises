using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStrings
{
    public class Call
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three strings to be merged:");
            String str1 = Console.ReadLine();
            String str2 = Console.ReadLine();
            String str3 = Console.ReadLine();

            MergeString merge = new MergeString();
            merge.Merge(str1, str2, str3);

            Console.ReadLine();

        }
    }
}
