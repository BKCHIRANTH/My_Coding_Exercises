using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalizeString
{
    public class Capitalize
    {
        public String CapitalizeName(String name)
        {
           
            if(double.TryParse(name, out _))
            {
                Console.WriteLine("Name cannot be a number!");
                return null;
            }

            if(name == " " || name == "")
            {
                String greetNull = "Hello ANONYMOUS, nice to meet you!";
                Console.WriteLine(greetNull);
                return greetNull;
            }
            String nameCap = name.ToUpper();    
            String greet = "Hello " + nameCap + ", nice to meet you!";
            Console.WriteLine(greet);
            return greet;

        }
    }
}
