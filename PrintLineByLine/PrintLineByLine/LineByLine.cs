using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLineByLine
{
   public class LineByLine
    {
        public String[] PrintLineByLine(String inputString)
        {
            if(inputString == null)
            {
                Console.WriteLine("No string entered!");
                return null;
            }

            if(double.TryParse(inputString,out _))
            {
                Console.WriteLine("Cannot input numbers!");
                return null;
            }

            if (inputString.Any(char.IsDigit))
            {
                Console.WriteLine("Names cannot contain numbers!");
                return null;
            }

            String[] words = new String[inputString.Length];

            inputString = inputString.Replace(" ", String.Empty);
            inputString = inputString.Replace(",", " ");
            words = inputString.Split(' ');

            Console.WriteLine("\n");
            Console.WriteLine("Desired Output:");
            
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            
            return words;
        }
    }
}
