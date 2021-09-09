using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSecondName
{
    class Call
    {
        static void Main(string[] args)
        {

            List<Student> studentList = new List<Student>() {
                new Student() { Studentfname = "ziva", StudentSecname = "1234" } ,
                new Student() { Studentfname = "shyam", StudentSecname = "Abhishek" } ,
                new Student() { Studentfname = "Apple", StudentSecname = "ohm"  } ,

            };

            SortSecond sort = new SortSecond();
            sort.sortSecName(studentList);

            Console.ReadLine();
        }
    }
}
