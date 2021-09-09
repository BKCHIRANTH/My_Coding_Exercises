using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    public abstract class StudentAbstract : IStudent
    {
        public string[] SportsStudents(string name, string dept, string sport)
        {
            string[] sportStudent = new string[5];
            Console.WriteLine("Student: {0} of {1} dept plays {2}", name, dept, sport);
            sportStudent[0] = name;
            sportStudent[1] = dept;
            sportStudent[2] = sport;
            return sportStudent;
        }

        public string[] NormalStudents(string name, string dept, string major)
        {
            string[] normalStudent = new string[5];
            Console.WriteLine("Student: {0} of {1} dept studies {2}", name, dept, major);
            normalStudent[0] = name;
            normalStudent[1] = dept;
            normalStudent[2] = major;
            return normalStudent;
        }

    public abstract string Achievements(string achieve);
    }
}
