using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Inheritance
{
    public class College
    {
        public string collegeName = "VVCE";
        public string work, dept;
        public string Duty(string workType)
        {
            Console.WriteLine("Work Type: " + workType);
            return workType;
        }
        public void Department(string dept)
        {
            Console.WriteLine("Department: " + dept);
        }
    }
}
