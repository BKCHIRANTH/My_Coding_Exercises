using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Concept_Inheritance
{
   public class Student : College
    {
        public string studentName;
        public string majorSub;
        public string Major(string major)
        {
            Console.WriteLine("Major Subject: " + major);
            return major;
        }

    }
}
