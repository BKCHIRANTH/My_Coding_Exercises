using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTables
{
   public class MultiplicationTable
    {
        public int[] GetTable(int input)
        {
            int[] finalTable = new int[input*input];
            int cnt = 0;

            if(input <= 0)
            {
                //Console.WriteLine("Enter a postive number");
                //int lin = Convert.ToInt32(Console.ReadLine());
                //GetTable(lin);
                return null;
            }

            for(int i = 1; i <= input; i++)
            {
                Console.Write("    "+i);  //Horizontal Fixed Row
            }

            Console.WriteLine();
            for(int i = 1; i <= input; i++)
            {
                Console.Write("\n");
                Console.Write(i);  //Vertical Fixed Row
                for(int j = 1; j <= input; j++)
                {
                     Console.Write("    " + i * j);
                     finalTable[cnt++] = i * j;
                }
                Console.WriteLine("\n");
            }

            return finalTable;
        }
        static void Main(string[] args)
        {
            MultiplicationTable table = new MultiplicationTable();
            Console.WriteLine("Enter the desired table input");
            int lines = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine();

            int[] returnedTable = table.GetTable(lines);
            if (returnedTable == null)
            {
                Console.WriteLine("Enter a positive value");
                int lines1 = Convert.ToInt32(Console.ReadLine());
                table.GetTable(lines1);
            }
            Console.ReadLine();
        }
    }
}
