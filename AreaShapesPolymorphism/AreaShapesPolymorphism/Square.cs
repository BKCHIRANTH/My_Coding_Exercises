using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapesPolymorphism
{
   public class Square : Shapes
    {
        public double side { get; set; }
        public Square()
        {
            side = 5.2;
        }
        public double squareArea;
        public override double area()
        {
            if (side <= 0)
            {
                return 0;
            }
            squareArea = side * side;
            squareArea = Math.Round(squareArea * 100) / 100;
            return squareArea;

        }
    }
}
