using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationWithRegularExpressions
{
    class Call
    {
        static void Main(string[] args)
        {
            Validation valid = new Validation();

            String hexa = "1At";
            bool hexaCheck =  valid.checkHexa(hexa);

            if (hexaCheck)
            {
                Console.WriteLine("{0} is a valid hexadecimal value", hexa);
            }
            else
            {
                Console.WriteLine("{0} is not a valid hexadecimal value", hexa);
            }

            Console.WriteLine("\n");
            String ip = "116.112.1.1";
            if (valid.checkip(ip))
            {
                Console.WriteLine("{0} is a valid IP Address", ip);

            }
            else
            {
                Console.WriteLine("{0} is not a valid IP Address", ip);
            }

           // valid.parseHexa("1A@#%");
            Console.ReadLine();
        }
    }
}
