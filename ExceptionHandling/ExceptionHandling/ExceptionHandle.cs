using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public class ExceptionHandle
    {
        public int[] Divideby(int param1, int param2)
        {
            int[] result = new int[1];
            try
            {
                result[0] = param1 / param2;
                //result[1] = param1 / param2; //Index Out of Range

                //if (param1 <= 0)
                //{
                //    throw (new OneofParamZeroException("Numerator must also be a positive number"));
                //}

            }
            catch(ArithmeticException e)
            {
                Console.WriteLine("Divide by zero not possible");
                return null;
            }

            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index Out of Range Exception occured");
                return null;
            }

            catch(Exception e)
            {
                Console.WriteLine("Parent Exception");
                return null;
            }

            try
            {
                if (param1 <= 0)
                {
                    throw (new OneofParamZeroException("Numerator must also be a positive number"));
                }
            }
            catch (OneofParamZeroException OnePramZero)
            {
                Console.WriteLine(OnePramZero.Message.ToString());
                return null;
            }

            Console.WriteLine("Quotient= {0}", result[0]);
            return result;
        }
    }
}
