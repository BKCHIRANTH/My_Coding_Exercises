using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SortArray
{
   public class Sort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of names to be entered");
            int num = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[num];
          
            for (int i = 0; i < num; i++)
            {
                names[i] = Console.ReadLine();   //read input string
            }
            Console.ReadLine();

            Sort sortObject = new Sort();
            string[] returnNames = sortObject.SortNamesInReverseOrder(names);

            if (returnNames == null)
            {
                Console.WriteLine("Invalid Entry");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Sorted List");
            for (int i = 0; i < returnNames.Length; i++)
            {
                Console.WriteLine(returnNames[i]);
            }
            
            Console.ReadLine();
        }


        public string[] SortNamesInReverseOrder(string[] namesUser)
        {
            int num = namesUser.Length;

            for (int i = 0; i < num; i++)
            {

                if (namesUser[i].Any(char.IsDigit))    //check if any number is entered
                {
                    return null;
                }
            }
            
            Array.Sort(namesUser);
            Array.Reverse(namesUser);
            
            return namesUser;
        }

        public string[] SortNamesInReverseOrder(char[] names)
        {
            throw new NotImplementedException("Invalid Input");
        }
    }
}
