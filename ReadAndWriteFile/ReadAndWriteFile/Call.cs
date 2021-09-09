using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWriteFile
{
    class Call
    {
        static void Main(string[] args)
        {
            ReadAndWrite readwrite = new ReadAndWrite();
            readwrite.Read("D:\\Exercise_Problems\\temp_read.txt");

            Console.WriteLine("\n");
            readwrite.Write("D:\\Exercise_Problems\\temp_write.txt");

            Console.ReadLine();
        }
    }
}
