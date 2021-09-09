using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    //public class Carnivores : Animal    Cannot inherit as Animal is static - "Sealed"
    public class Carnivores
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the animal name");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter the way it makes sound");
            string sound = Console.ReadLine();

            // Animal an = new Animal();       Not Possible since Animal is class specific
           
            Console.WriteLine("\n");
            Animal.Sound(animal, sound);

            Console.ReadLine();
        }
    }
}
