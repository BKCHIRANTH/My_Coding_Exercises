using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ClassBasedGroup
{
   public class ClassGroup
    {

        Dictionary<string, string> dict = new Dictionary<string, string>();

        public Dictionary<string, string> InsertStudents(string names, string std)
        {
            
            dict.Add(names, std);

            return dict;
        }

        
        public ArrayList getNames(string std)
        {
            if (std == null)
            {
                return null;
            }
            List<string> valuesToFind = new List<string> { std .ToString()};
          

            var respectiveKeys = dict.Where(kvp => valuesToFind.Any(y => y == kvp.Value)).Select(kvp => new { student = kvp.Key });

            ArrayList names = new ArrayList();

            Console.WriteLine("List of students in class {0}:", std);
            foreach (var key in respectiveKeys)
            {
                Console.WriteLine(key);
                names.Add(key.ToString());
            }

            //Console.Write("\n");
            //foreach (string s in names)
            //{
            //    Console.WriteLine(s);
            //}

            return names;
        }

        


    }
}
