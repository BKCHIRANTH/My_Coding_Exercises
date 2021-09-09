using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeArrayReflection
{
    class Call
    {
        static void Main(string[] args)
        {
            Array arr = new int[7];

            Console.WriteLine("Size before resizing: {0}", arr.Length);
            ResizeArray resize = new ResizeArray();

            int newarray = resize.resizearrays(ref arr, 9);
            Console.WriteLine("Size after resizing: {0}", newarray);

            Console.ReadLine();

        }
    }
}
