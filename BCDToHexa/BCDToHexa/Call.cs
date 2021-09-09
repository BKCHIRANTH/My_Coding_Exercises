using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCDToHexa
{
    class Call
    {
        static void Main(string[] args)
        {
            String bcd = "10000010";
           
            BCDHexa convert = new BCDHexa();
            String binary = convert.bcdToBinary(bcd);
            //Console.WriteLine(binary);

            convert.binaryToHexaDecimal(binary.ToCharArray());

            Console.ReadLine();

        }
    }
}
