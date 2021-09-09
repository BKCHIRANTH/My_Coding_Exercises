using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentifyInterfacesUsingReflection
{
    class Call
    {
        static void Main(string[] args)
        {
            Identify idObj = new Identify();

            Type t = typeof(Identify);
            idObj.getInterfaces(t);

            Console.ReadLine();
            
        }
    }
}
