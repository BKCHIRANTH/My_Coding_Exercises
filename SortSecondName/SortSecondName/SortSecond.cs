using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSecondName
{
   public class SortSecond
    {
        public String[] sortSecName(List<Student> names)
        {
           

            var orderByResult = from s in names
                                orderby s.StudentSecname //Sorts by second name
                                select s;

            String[] result = new String[names.Count];
            int cnt = 0;
            Console.WriteLine("Ascending Order based on Second Name:");

            foreach (var std in orderByResult)
            {
                Console.WriteLine(std.Studentfname + " " + std.StudentSecname);
                result[cnt++] = std.Studentfname + " " + std.StudentSecname;
                
            }

            return result;
        }
    }
}
