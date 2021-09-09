using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvokeMethodReflections
{
   public class Student
    {
        public String GetDetails(String RollNumber, String Name)
        {
            Console.WriteLine("RollNumber: {0} and Name: {1}", RollNumber, Name);
            return RollNumber +" "+ Name;
            
        }

    }
}
