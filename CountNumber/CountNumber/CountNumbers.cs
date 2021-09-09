using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumber
{
    public class CountNumbers
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Enter the no of inputs to be entered");
            int num = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[num];

            CountNumbers count = new CountNumbers();

            for (int i = 0; i < num; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());   //read input numbers
            }
            Console.ReadLine();

            int[] returnNumber = count.Counter(numbers);

            if (returnNumber == null)
            {
                Console.WriteLine("Invalid Entry");
                Console.ReadLine();
                Environment.Exit(0);
            }
            count.Counter(numbers);
            Console.ReadLine();
        }

        public int[] Counter(int[] inputNumbers)
        {
            int leng = inputNumbers.Length;
            if (inputNumbers == null)
            {
                return null;
            }

            for (int i = 0; i < leng; i++)
            {
                if (inputNumbers[i] < 0)
                {
                    return null;
                }
            }

            int cnt;
            int b = 0;
            int ind = 0;
            int a;
            int[] result = new int[10];

            for (int i = 0; i < leng; i++)
            {
                if (inputNumbers[i] != (int)inputNumbers[i])    //check if any number is entered
                {
                    return null;
                }
            }

            do
            {
                cnt = 0;
                a = b;
                
                for (int i = 0; i < leng; i++)     //traversing the input array
                {

                    if (inputNumbers[i] >= a && inputNumbers[i] <= a + 9)
                    {
                        cnt++;
                    }
                }

                Console.WriteLine("NO of items between {0} and {1} is {2}", a, a + 9, cnt);
                result[ind++] = cnt;  //storing the counts in an array
                b = b + 10;
                
            } while (a < 90);

            return result;
        }
    }
}
