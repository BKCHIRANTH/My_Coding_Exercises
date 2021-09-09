using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadHTMLAndTextFiles
{
    class Call
    {
        static void Main(string[] args)
        {
            ReadHTMLTextFiles read = new ReadHTMLTextFiles();
            read.readTextFile("D:\\Exercise_Problems\\ReadHTMLAndTextFiles");
           
            read.readHTMLFile("D:\\Exercise_Problems\\ReadHTMLAndTextFiles");

            Console.ReadLine();
        }
    }
}
