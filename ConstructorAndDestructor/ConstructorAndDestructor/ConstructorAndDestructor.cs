using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndDestructor
{
   public class ConstructorAndDestructor
   {
        public string name;

        public ConstructorAndDestructor()
        {
            //empty constructor
            Console.WriteLine("Hi All!");
        }

        public ConstructorAndDestructor(string name1)
        {
            //parameterized constructor
            int leng = name1.Length;
            char charToRepeat = 'X';
            name1 = new string(charToRepeat, leng);
            this.name = name1;
        }

        ~ConstructorAndDestructor()
        {
            //Destructor
            
            Console.WriteLine("Bye " + this.name);
            Console.ReadLine();
            Environment.Exit(0);
        }
   }
}
