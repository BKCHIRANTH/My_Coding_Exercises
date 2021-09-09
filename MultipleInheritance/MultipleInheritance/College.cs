using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    public class College : IStudent, IStaff
    {
        //Student Interface
        public string[] StudentDetails(string name, string dept)
        {
            string[] studentResult = new string[10];
            Console.WriteLine("Student Name: {0}", name);
            Console.WriteLine("Student Dept: {0}", dept);
            studentResult[0] = name;
            studentResult[1] = dept;
            return studentResult;
        }
        //Staff Interface
        public string[] StaffDetails(string name, string shift)
        {
            string[] staffResult = new string[10];
            Console.WriteLine("Staff Name: {0}", name);
            Console.WriteLine("Staff Shift: {0}", shift);
            staffResult[0] = name;
            staffResult[1] = shift;
            return staffResult;
        }

        static void Main(string[] args)
        {
            College collegeObj = new College();
            collegeObj.StudentDetails("Dassault","Physics");
            Console.WriteLine("\n");

            collegeObj.StaffDetails("Sam", "Morning");
            Console.ReadLine();

        }
    }
}
