using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SerializationAndDeserialization
{
    class Call
    {
        static void Main(string[] args)
        {
            //Serializer serialObj = new Serializer();

            //string strPath = " ";
            //string strInput = " ";
            //string strOutput = " ";

            //strPath = Directory.GetCurrentDirectory() + @"\Sample_XML_File.xml";
            //strInput = File.ReadAllText(strPath);

            //Student student = serialObj.Deserialize<Student>(strInput);
            //strOutput = serialObj.Serialize<Student>(student);

            //Console.WriteLine(student.StudentName+"'s data");
            //Console.Write("\n");
            //Console.WriteLine(strOutput);

            Console.WriteLine("-----Serialized Address Data-----");

            Serializer<Student> serilaizeAddress;

            Student address = new Student { HouseNo = 32, StreetName = "NH Colony", City = "Bangalore", Country = "India" };

            serilaizeAddress = new Serializer<Student>();

            string serailizedAddress = serilaizeAddress.SerializeData(address);

            Console.WriteLine("Serialized Address Data : ");

            Console.WriteLine(serailizedAddress);

            Console.Write("\n");

            Console.WriteLine("-----Deserialized Address Data-----");

            Student deserialiedAddress = serilaizeAddress.DeserializeData(serailizedAddress);

            Console.WriteLine("House No :{0}, Street :{1}, City : {2}, Country: {3}", deserialiedAddress.HouseNo, deserialiedAddress.StreetName, deserialiedAddress.City, deserialiedAddress.Country);
            
            Console.ReadLine();

        }
    }
}
