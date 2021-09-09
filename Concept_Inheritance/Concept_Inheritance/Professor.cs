using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Inheritance
{
    public class Professor : College
    {
        public string profName, subject;
        public string teach(string sub)
        {
            Console.WriteLine("Teaching Subject: " + sub);
            return sub;
        }

    }
}
