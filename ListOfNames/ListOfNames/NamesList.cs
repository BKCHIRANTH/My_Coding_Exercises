using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfNames
{
   public class NamesList
    {
        public String[] removeDuplicate(List<String> names)
        {
            for (int i=0;i<names.Count;i++)
            {
                if (names[i].ToString().Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid Names entered");
                    String[] turn = { "null" };
                    return turn ;
                }
            }

            Console.WriteLine("Unique names");
            String[] final = new string[names.Count];
            int cnt = 0;
            for (int i = 0; i < names.Count; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (names[i] == names[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(names[i]);
                    final[cnt++] = names[i];

                }

            }

            return final;
        }
    }
}
