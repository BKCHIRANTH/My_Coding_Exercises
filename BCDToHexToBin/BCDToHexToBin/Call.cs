using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDToHexToBin
{
    class Call
    {
        static void Main(string[] args)
        {
            

            BCDHexBin convert = new BCDHexBin();

            //String bcd = "10010001";
            String bcd = "100000000";

            String binary = convert.bcdToBinary(bcd);
            

            convert.binaryToHexaDecimal(binary.ToCharArray());

            Console.WriteLine("Equivalent Binary value: {0}", binary);

            Console.ReadLine();
        }
    }
}
