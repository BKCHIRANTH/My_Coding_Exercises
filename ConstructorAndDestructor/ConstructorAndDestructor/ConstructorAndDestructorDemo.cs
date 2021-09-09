using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
   public class ConstructorAndDestructorDemo
    {
        static void Main(string[] args)
        {
                ConstructorAndDestructor cdObj1 = new ConstructorAndDestructor();
                ConstructorAndDestructor cdObj2 = new ConstructorAndDestructor("Example");
                Console.WriteLine("Hi " + cdObj2.name);
                
        }
    }
}
