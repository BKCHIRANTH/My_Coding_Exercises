using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
    public sealed class Vehicle
    {
        public double mileage(double cc)
        {
            Console.WriteLine("Sealed Class Vehicle");
            Console.WriteLine("Mileage= {0}", cc / 2);
            return cc / 2; ;
        }

        
    }
}
