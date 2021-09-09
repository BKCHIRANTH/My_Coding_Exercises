using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapesPolymorphism
{
    public class Rectangle : Shapes
    {
        public double length { get; set; }
        public double breadth { get; set; }
        public Rectangle()
        {
            length = 4;
            breadth = 12.1;
        }
        public double rectangleArea;
        public override double area()
        {
            if (length <= 0 || breadth <= 0) 
            {
                return 0;
            }
            rectangleArea = length * breadth;
            rectangleArea = Math.Round(rectangleArea * 100) / 100;

            return rectangleArea;
        }
    }
}
