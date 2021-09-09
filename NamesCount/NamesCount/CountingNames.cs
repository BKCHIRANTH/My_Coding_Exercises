using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesCount
{
   public class CountingNames
    {
        public String getCounts(List<String> names)
        {
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i].ToString().Any(char.IsDigit))
                {
                    Console.WriteLine("Invalid Names entered");
                    return null;
                }
            }

            int[] repeatChars = new int[100];
            String[] name = new String[50];
            

            for(int i = 0; i < names.Count; i++)
            {
                name[i] = names[i];
            }
            

            int[] fr = new int[name.Length];
            int[] run = new int[name.Length];
            int h = 0;
            int visited = -1;

            for (int i = 0; i < name.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < name.Length; j++)
                {
                    if(name[i] == " ")
                    {
                        continue;
                    }

                    if (name[i] == name[j])
                    {
                        count++;
                        
                        fr[j] = visited;    //To avoid counting same element again  
                    }
                }

                if (fr[i] != visited)
                {
                    fr[i] = count;
                    run[i] = count;
                    
                }
                    
            }


            //for (int i = 0; i < fr.Length-2; i++)
            //{
            //    run[i] = fr[i];
            //}



            //for (int i = 0; i < fr.Length-2; i++)
            //{
            //    Console.WriteLine(" " + run[i]);
            //}

            String tot = " ";

            for (int i = 0; i < fr.Length; i++)
            {
                if (fr[i] != visited)
                {
                    Console.WriteLine(name[i] + " occurred " + fr[i] + "times");
                    tot += fr[i].ToString();

                }

            }
            tot = tot.Substring(0, tot.Length - 2);

            //char[] ch = tot.ToCharArray();


            //for (int i = 1; i < ch.Length; i++)
            //{
            //    Console.WriteLine(i + " " + ch[i]);
            //}

            //Console.WriteLine(tot);

            //for (int i = 1; i < fr.Length; i++)
            //{
            //    Console.WriteLine(name[i] + " occurred " + ch[i] + "times");
            //}

            

            return tot;

        }
        }
}
