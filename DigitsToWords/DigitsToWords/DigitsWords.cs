using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitsToWords
{
    public class DigitsWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            DigitsWords digiword = new DigitsWords();
            string[] wordss = digiword.DigitsToWords(num);
            foreach(string s in wordss)
            {
                Console.Write(" " +s);
            }

            Console.ReadLine();
        }
        
        public string[] DigitsToWords(int number)
        {
            int reverse = 0;

            if (number < 0)
            {
                //to make the number positive
                number = number * 2;
                number = number * -1;
                number = number / 2;

            }

            if (number == 0)
            {
                string[] wordZero = new string[] { "Zero" };
                return wordZero;
            }
            //reversing the number
            while (number != 0)
                {
                    //using modulus extract the last digit
                    reverse = (reverse * 10) + (number % 10);

                    //get the rest of the number after removing last digit
                    number = number / 10;

                }
            
                string[] words = new string[10]; //to store the words
                int i = 0;
           
                while (reverse != 0)
                {


                    switch (reverse % 10)    //get the last digit of the original number
                    {

                        case 0: words[i] = "Zero";
                                break;

                        case 1: words[i] = "One";
                                break;

                        case 2: words[i] = "Two";
                                break;

                        case 3: words[i] = "Three";
                                break;

                        case 4: words[i] = "Four";
                                break;

                        case 5: words[i] = "Five";
                                break;

                        case 6: words[i] = "Six";
                                break;

                        case 7: words[i] = "Seven";
                                break;

                        case 8: words[i] = "Eight";
                                break;

                        case 9: words[i] = "Nine";
                                break;
                    }
                    reverse = reverse / 10; //reading remaining digits
                    i++; //checking number of digits
                }
            
            //for (int j = 0; j <= i; j++)
            //{
            //    Console.Write(" " + words[j]);
            //}
            
                return words;
            
            
        }
    }
}
