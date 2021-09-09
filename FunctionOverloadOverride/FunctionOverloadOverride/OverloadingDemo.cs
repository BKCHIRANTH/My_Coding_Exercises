using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloadOverride
{
   public class OverloadingDemo
    {
        
        public int area()
        {
            int defArea = 100;
            Console.WriteLine("Area is default");
            return defArea;
        }

        public int area(int side)
        {
            int sideArea;
            sideArea = side * 10;
            Console.WriteLine("Area is " + sideArea+" sq.mts");
            return sideArea;
        }

        public int area(int side1, int side2)
        {
            int newArea;
            newArea = side1 + side2;
            Console.WriteLine("Area is " + newArea+" sq.mts");
            return newArea;
        }

        public virtual int Volume(int param)
        {
            return param;
        }
    }
}
