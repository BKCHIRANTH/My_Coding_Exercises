using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAndSpecificExceptions
{
   public class Division
    {
        public double[] Divide(double inp1, double inp2)
        {
            double[] result = new double[1];
            try
            {
                result[0] = inp1 / inp2;
                //result[1] = param1 / param2; //Index Out of Range
               
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero not possible");
                return null;
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Out of Range Exception occured");
                return null;
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception occured");
                return null;
            }

           

            Console.WriteLine("Quotient= {0}", result[0]);
            return result;
        }
    }
}
