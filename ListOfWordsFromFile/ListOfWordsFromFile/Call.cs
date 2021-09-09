using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfWordsFromFile
{
    class Call
    {
        static void Main(string[] args)
        {
            Operations ops = new Operations();
            ops.readFile("D:\\Exercise_Problems\\ListOfWordsFromFile\\Sample_File.txt");
           
            Console.ReadLine();
        }
    }
}
