using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
   public class OpOverloadString
    {
        
        public string random;

        public OpOverloadString()
        {

        }
        public OpOverloadString(string i)
        {
            this.random = i;

        }

        public static OpOverloadString operator +(OpOverloadString op1, OpOverloadString op2)
        {

            string strA = op1.random;
            string strB = op2.random;

            if (strA == " " || strB == " ")
            {
                Console.WriteLine("Cannot take null input");
                OpOverloadString tem = new OpOverloadString();
                tem.random = " ";
                return tem;
            }

            int leng = strA.Length + strB.Length;

            char[] charArray1 = strA.ToCharArray();
            char[] charArray2 = strB.ToCharArray();
            char[] charArray3 = new char[leng];
            
            int cnt = 0;
            foreach (char ch in charArray1)
            {
                charArray3[cnt] = ch;  //Inserting alternate chars of string1
                cnt += 2;
            }

            cnt = 1;
            foreach (char ch in charArray2)
            {
                charArray3[cnt] = ch;   //Inserting alternate chars of string2
                cnt += 2;
            }

            string finalJuggledString = new string(charArray3);    //Juggled string
           

            OpOverloadString temp = new OpOverloadString();
            temp.random = finalJuggledString;
            return temp;
        }

        public string GetString()
        {
            Console.WriteLine("New String: {0}", random);
            return random;

        }
    }
}
