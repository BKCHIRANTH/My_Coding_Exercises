using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCommasToNumber
{
    public class AddComma
    {
        public String addCommasToNumericString(String digits)
        {
            if(!(double.TryParse(digits, out _)))
            {
                Console.WriteLine("Please enter a number");
                return null;
            }

            double digitNum = double.Parse(digits);
            String digitWithComma = digitNum.ToString("#,##0.##");
            
            Console.WriteLine("Your Number: {0}", digitWithComma);

            return digitWithComma;
        }
    }
}
