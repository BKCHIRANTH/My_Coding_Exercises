using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    public class Splendor : Bike
    {

        public sealed override double Mileage(double cc)    //sealing a virtual method
        {
            Console.WriteLine("Splendor class Method");
            Console.WriteLine("Mileage of Splendor: {0}", cc / 3);
            return cc / 3;
        }
    }
}
