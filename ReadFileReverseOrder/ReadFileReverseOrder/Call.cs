using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFileReverseOrder
{
    class Call
    {
        static void Main(string[] args)
        {
            ReadFile readReverse = new ReadFile();
            readReverse.readFileReverse("D:\\Exercise_Problems\\temp_readRev.txt");

            Console.ReadLine();
        }
    }
}
