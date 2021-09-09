using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    //class Bike : Vehicle     Error: Cannot inherit a sealed class
   public class Bike
    {
      
        public virtual double Mileage(double cc)
        {
            Console.WriteLine("Bike class Method");
            Console.WriteLine("Mileage: {0}", cc/2 );
            return cc/2;
        }
    }
}
