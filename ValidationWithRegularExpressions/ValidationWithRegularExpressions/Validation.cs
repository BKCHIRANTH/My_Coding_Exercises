using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ValidationWithRegularExpressions
{
   public class Validation
    {
        public bool checkHexa(String hexa)
        {
            Regex reg = new Regex("^[a-fA-F0-9]+$");
            bool valid = false;

            if(hexa == null)
            {
                valid = false;
            }

            else
            {
                valid = reg.IsMatch(hexa);
                
            }
            
            return valid;
        }


        public bool checkip(String ip)
        {
            String check = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";

            Regex reg = new Regex(check);

            if(ip == null)
            {
                return false;
            }

            else
            {
                return reg.IsMatch(ip);
            }
        }

        public bool checkFileName(String file)
        {
            Regex reg = new Regex("^[_](0[1-9]|[12][0-9]|3[01])(0[1-9]|1[012])(19|20)|[_][1-8]+");

            if(file == null)
            {
                return false;
            }

            else
            {
                return reg.IsMatch(file);
            }   
        }

        public String parseData(String data)
        {
            String check = @"^[a-zA-Z]{3}[>]{2}";
            Regex reg = new Regex(check);
            
            if(data == null)
            {
                return null;
            }

            if (reg.IsMatch(data))
            {
                return check;
            }

            return null;
        }

        //public String parseHexa(String hexa)
        //{
        //    String check = @"[#%$&*]+";
        //    char[] sign = { '$', '%', '@', '#' };
        //    Regex reg = new Regex(check);

        //    if (hexa == null)
        //    {
        //        return null;
        //    }

            
        //    List<char> ch = new List<char>(hexa);
        //    //for (int i = 0; i < ch.Count; i++)
        //    //    Console.Write(ch[i]);

        //    for (int i = 0; i < ch.Count; i++)
        //        {
        //        if((ch[i] == '%') || (ch[i] == '@') || ( ch[i] == '#'))
        //        {
        //            ch.Remove(ch[i]);
        //        }
               
                    
        //        }

        //    for (int i = 0; i < ch.Count; i++)
        //        Console.Write(ch[i]);
        //    return hexa;

        //}


    }
}
