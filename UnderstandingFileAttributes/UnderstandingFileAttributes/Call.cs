using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace UnderstandingFileAttributes
{
    class Call
    {
        static void Main(string[] args)
        {
            FileAttributes attribute = new FileAttributes();

            string filePath = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File.txt";
            attribute.setReadOnly(filePath);

            Console.WriteLine("\n");
            string filePath1 = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File1.txt";
            attribute.toCompress(filePath1);

            string filePath2 = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File2.txt";
            string filePath3 = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File3.txt";

            Console.WriteLine("\n");
            string filePath4 = "D:\\Exercise_Problems\\UnderstandingFileAttributes\\Sample_File4.txt";
            attribute.toHide(filePath4);

            Console.WriteLine("\n");
            attribute.getAttributes(filePath4);


            System.IO.DriveInfo di = new System.IO.DriveInfo("D:\\");
            Console.WriteLine("\n");
            Console.WriteLine(di.TotalFreeSpace);
            Console.WriteLine(di.VolumeLabel);

            Console.WriteLine("\n");
            System.IO.DirectoryInfo dirInfo = di.RootDirectory;   //root dir info
            Console.WriteLine(dirInfo.Attributes.ToString());
            

            Console.WriteLine("\n");
            string currentDirName = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine("Current Directory: "+currentDirName);

            string fileName = filePath2;

            
            FileInfo info = new FileInfo(fileName);
            long length = info.Length;

            Console.WriteLine("\n");
            Console.WriteLine("LENGTH IN BYTES: {0}", length);

            Console.ReadLine();
        }
    }
}
