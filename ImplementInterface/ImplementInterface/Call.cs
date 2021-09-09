using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
   public class Call
    {
        static void Main(string[] args)
        {
            SportsStudent sports = new SportsStudent();
            sports.SportsStudents("Teddy", "Physics", "Football");
            sports.Achievements("National Level Player");
            sports.Excusehours(2);
            Console.WriteLine("\n");

            NormalStudent normal = new NormalStudent();
            normal.NormalStudents("Ronny", "Mathematics", "Linear Algebra");
            normal.Achievements("OLympiad Winner");
            normal.GraceCalculate(5);
            Console.ReadLine();
        }
    }
}
