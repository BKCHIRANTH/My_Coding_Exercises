using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDToHexToBin
{
   public class BCDHexBin
    {
        //public void BcdToHexToBinConvert()   //char[] hexdec
        //{
        //    int i = 0x12345678;
        //    int v = 0;
        //    foreach (byte b in BitConverter.GetBytes(i).Reverse())
        //    {
        //        v = (v << 6) + (v << 5) + (v << 2); // next byte: multiply by 100
        //        v += (b & 0x0F) + ((b >> 1) & 0x78) + ((b >> 3) & 0x1E); // 0xUV = 0x0V + 10 * (0xU0 / 16) = 0x0V + 1/2*0xU0 + 1/8*0xU0
        //    }
        //    Console.WriteLine("0x{0:X8} -> {1} = 0x{1:X8}", i, v);



        //    //int i = 0;

        //    //while (hexdec[i] != '\0')
        //    //{

        //    //    switch (hexdec[i])
        //    //    {
        //    //        case '0':
        //    //            System.Console.Write("0000");
        //    //            break;
        //    //        case '1':
        //    //            System.Console.Write("0001");
        //    //            break;
        //    //        case '2':
        //    //            System.Console.Write("0010");
        //    //            break;
        //    //        case '3':
        //    //            System.Console.Write("0011");
        //    //            break;
        //    //        case '4':
        //    //            System.Console.Write("0100");
        //    //            break;
        //    //        case '5':
        //    //            System.Console.Write("0101");
        //    //            break;
        //    //        case '6':
        //    //            System.Console.Write("0110");
        //    //            break;
        //    //        case '7':
        //    //            System.Console.Write("0111");
        //    //            break;
        //    //        case '8':
        //    //            System.Console.Write("1000");
        //    //            break;
        //    //        case '9':
        //    //            System.Console.Write("1001");
        //    //            break;
        //    //        case 'A':
        //    //        case 'a':
        //    //            System.Console.Write("1010");
        //    //            break;
        //    //        case 'B':
        //    //        case 'b':
        //    //            System.Console.Write("1011");
        //    //            break;
        //    //        case 'C':
        //    //        case 'c':
        //    //            System.Console.Write("1100");
        //    //            break;
        //    //        case 'D':
        //    //        case 'd':
        //    //            System.Console.Write("1101");
        //    //            break;
        //    //        case 'E':
        //    //        case 'e':
        //    //            System.Console.Write("1110");
        //    //            break;
        //    //        case 'F':
        //    //        case 'f':
        //    //            System.Console.Write("1111");
        //    //            break;
        //    //        default:
        //    //            System.Console.Write("\nInvalid hexadecimal digit " +
        //    //                                                      hexdec[i]);
        //    //            break;
        //    //    }
        //    //    i++;
        //    //}



        //}


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

            
            ans = reverse(ans1.ToString()); 
            
            

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

                   
                    check = 0;
                    sum = 0;
                    mul = 1;
                }
            }

            len = ans.Count;

            
           

            String hexa = " ";
            for (int i = len - 1; i >= 0; i--)
                hexa += ans[i];

            Console.WriteLine("Equivalent HexaDecimal value: {0}",hexa);
            


            return hexa;
        }


    }
}
