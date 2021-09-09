using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeArrayReflection
{
   public class ResizeArray
    {
        public int resizearrays(ref Array array, int newSize)
        {
            if(newSize < 0)
            {
                return -1;
            }
            
            Type elementType = array.GetType().GetElementType();
            Array newArray = Array.CreateInstance(elementType, newSize);
            Array.Copy(array, newArray, Math.Min(array.Length, newArray.Length));
            array = newArray;

            return array.Length;
        }
    }
}
