using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasedGroup
{
    class Call
    {
        static void Main(string[] args)
        {
            ClassGroup grpObj = new ClassGroup();
            grpObj.InsertStudents("Pia","1");
            grpObj.InsertStudents("Jam","2");
            grpObj.InsertStudents("Sam","1");
            grpObj.InsertStudents("Amy","3");

            grpObj.getNames("1");
            Console.ReadLine();

        }
    }
}
