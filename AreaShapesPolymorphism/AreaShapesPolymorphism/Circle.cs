using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaShapesPolymorphism
{
    public class Circle : Shapes
    {
        // public double Radius { get; set; }
        public double Radius;
       
        public Circle()
        {
            Radius = 5;
        }
        public double circleArea;
        public override double area()
        {
            if (Radius <= 0)
            {
                return 0;
            }
            circleArea = Math.PI * Radius * Radius;
            circleArea = Math.Round(circleArea * 100) / 100;
           
            return circleArea;
        }
    }
}
