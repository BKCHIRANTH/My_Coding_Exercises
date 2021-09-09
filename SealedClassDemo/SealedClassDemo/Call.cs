using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassDemo
{
   public class Call 
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            veh.mileage(110);     //sealed class methods accessible
            Console.WriteLine("\n");

            Bike bike = new Bike();
            bike.Mileage(110);
            Console.WriteLine("\n");

            Splendor splendor = new Splendor();
            splendor.Mileage(120);
            Console.ReadLine();

        }
    }
}
