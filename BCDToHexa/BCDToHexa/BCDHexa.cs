using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDToHexa
{
   public class BCDHexa
    {
        public String bcdToBinary(String bcd)
        {
            

            int l = bcd.Length;
            int num = 0;
            int mul = 1;
            int sum = 0;


            for (int i = l % 4 - 1; i >= 0; i--)   //if input bcd leng isn't divisible by 4
            {
                sum += (bcd[i] - '0') * mul;
                mul *= 2;
            }

            num = sum;
            sum = 0;

            mul = (int)Math.Pow(2, 3);
            int ctr = 0;

            for (int i = l % 4; i < l; i++)
            {
                ctr++;
                sum += (bcd[i] - '0') * mul;
                mul /= 2;
                if (ctr == 4)
                {
                    num = num * 10 + sum;
                    sum = 0;
                    mul = (int)Math.Pow(2, 3);
                    ctr = 0;
                }
            }

            // Convert decimal to binary
            String ans = "";
            while (num > 0)
            {
                ans += (char)(num % 2 + '0');
                num /= 2;
            }
            StringBuilder ans1 = new StringBuilder();

            // Append a string into StringBuilder input1
            ans1.Append(ans);


            ans = reverse(ans1.ToString());    // Reverse StringBuilder input1

            return ans;
        }


        public String reverse(String input)
        {
            char[] a = input.ToCharArray();
            int l, r = a.Length - 1;
            for (l = 0; l < r; l++, r--)
            {
                char temp = a[l];
                a[l] = a[r];
                a[r] = temp;
            }
            return String.Join("", a);
        }


        public String binaryToHexaDecimal(char[] s)
        {
           

            int len = s.Length, check = 0;
            int num = 0, sum = 0, mul = 1;
            List<char> ans = new List<char>();


            for (int i = len - 1; i >= 0; i--)
            {
                sum += (s[i] - '0') * mul;
                mul *= 2;
                check++;


                if (check == 4 || i == 0)     //store hexa in list
                {
                    if (sum <= 9)
                        ans.Add((char)(sum + '0'));
                    else
                        ans.Add((char)(sum + 55));

                    // Reinitializing all
                    // variables for next group.
                    check = 0;
                    sum = 0;
                    mul = 1;
                }
            }

            len = ans.Count;

            Console.WriteLine("Equivalent HexaDecimal value:");
            //for (int i = len - 1; i >= 0; i--)
                //Console.Write(ans[i]);



            String hexa = " ";
            for (int i = len - 1; i >= 0; i--)
                hexa += ans[i];

            
            Console.WriteLine(hexa);
            

            return hexa;
        }
    }
}
