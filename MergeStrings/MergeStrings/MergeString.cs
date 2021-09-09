using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeStrings
{
    public class MergeString
    {
        public String Merge(String str1, String str2, String str3)
        {
            if(str1 == null && str2 == null && str3 == null)
            {
                Console.WriteLine("No words were entered");
                return null;
            }

            String merger = String.Concat(str1, str2, str3);

            StringBuilder merger1 = new StringBuilder();
            merger1.Append(str1);
            merger1.Append(" "+str2);
            merger1.Append(" "+str3);

            Console.WriteLine("Merged string: {0}", merger1);
            Console.WriteLine("Merged string: "+ str1 + " " + str2 + " " + str3);
            Console.WriteLine("Merged string: {0}", merger);

            return merger;
        } 
    }
}
