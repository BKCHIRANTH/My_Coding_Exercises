using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class Animal
    {
        public static string Sound(string animal, string sound)     //methods must be static
        {
            Console.WriteLine("{0} {1}", animal, sound);
            return animal+ " " + sound;
        }
        
    }
}
