using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PrintTables
{
   public class PrintingTables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines");
            int line = Convert.ToInt32(Console.ReadLine());
            PrintingTables printtables = new PrintingTables();
            int[] negInput = printtables.PrintingTablePyramid(line);
            
            if (negInput == null)
            {
                Console.WriteLine("Enter the valid number of lines");
                int lineAgain = Convert.ToInt32(Console.ReadLine());
                printtables.PrintingTablePyramid(lineAgain);
            }
            Console.ReadLine();
        }

        public int[] PrintingTablePyramid(int lines)
        {
            int bound = lines * lines;
            int[,] tables = new int[bound,bound];

            if (lines > 0)
            {
                Console.WriteLine("Desired Table:");
                for (int i = 0; i <= lines; i++)
                {
                    //for printing no of items in each line
                    for (int j = 0; j <= i - 1; j++)
                    {
                        Console.Write(" " + i * j);

                        tables[i, j] = i * j;
                    }
                    Console.WriteLine("\n");
                }
            }
            else if (lines == 0)
            {
                Console.WriteLine("Desired Table:");
                int[] zero = new int[] { lines };
                for(int i=0; i <= lines; i++)
                {
                    Console.WriteLine("\n"+zero[i]);
                }
                return zero;
            }
            else
            {
                //if the no of lines is negetive
                //Console.WriteLine("Enter a valid no of lines");
                //int line = Convert.ToInt32(Console.ReadLine());
                //PrintingTablePyramid(line);
                return null;
            }

            int size = tables.Length;
            int[] result = new int[size];

            //copy 2D array elements into a 1D array.
            int write = 0;
            for (int i = 0; i <= lines; i++)
            {
                for (int z = 0; z <= i - 1; z++)
                {
                    result[write++] = tables[i, z];
                }
            }

            //getting the no of elements in the 1D array
            //int leng = 0;
            //for (int i = 0; i <= lines; i++)
            //{
            //    for (int z = 0; z <= i - 1; z++)
            //    {
            //        leng++;
            //    }
            //}

            // printing contents of 1D array
            //Console.WriteLine("1D ARRAY ELEMENTS");
            //for (int y = 0; y < leng; y++)
            //{

            //    Console.Write(" " + result[y]);

            //}

            return result;
        }

        public int[] PrintingTablePyramid(string num)
        {
            throw new NotImplementedException("Cannot input strings in place of numbers");
        }
    }
}
