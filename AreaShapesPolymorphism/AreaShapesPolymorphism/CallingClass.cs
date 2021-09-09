using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapesPolymorphism
{
    public class CallingClass
    {
        static void Main(string[] args)
        {
            Shapes circleObj = new Circle();
            Console.WriteLine("Area of circle = " + circleObj.area());

            Shapes rectangleObj = new Rectangle();
            Console.WriteLine("Area of Rectangle = " + rectangleObj.area());
            
            Shapes squareObj = new Square();
            Console.WriteLine("Area of square = " + squareObj.area());
            
            Console.ReadLine();
        }
    }
}
