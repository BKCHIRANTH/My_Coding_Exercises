using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPyramid
{
   public class PrintAPyramid
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of lines of pyramid:");
            int numlines = Convert.ToInt32(Console.ReadLine());

            PrintAPyramid pyramid = new PrintAPyramid();
            string[] result = pyramid.PrintingPyramid(numlines);
            if (result == null)
            {
                Console.WriteLine("Enter valid number");
                int numlinesagain = Convert.ToInt32(Console.ReadLine());
                pyramid.PrintingPyramid(numlinesagain);
            }

            //int n = 7;
            Console.WriteLine("Pyramid without loops:");
            pattern(numlines, numlines);

            Console.ReadLine();
        }

        public string[] PrintingPyramid(int line)
        {
            int negline = line;
            if (line < 0)
            {
                
                //to make the size positive
                negline = negline * 2;
                negline = negline * -1;
                negline = negline / 2;

            }
            int bound = negline * 20;
            string[] stars = new string[bound];
            if (line > 0)
            {
                
                int cnt = 0;
                int i, j;
                int space = line;
                Console.WriteLine("Pyramid with loops:");
                //main loop for number of rows
                for ( i = 0; i < line; i++)
                {
                    //loop for space per line
                    for ( j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                        stars[cnt++] = " ";
                    }
                    for (j = 0; j <= i; j++)
                    {
                        Console.Write("* ");
                        stars[cnt++] = "*";
                    }

                    Console.Write("\n");
                    space--;    //decreasing the space for next rows
                }
                //int leng = stars.Length;
                //for (int z = 0; z < leng; z++)
                //{
                //    Console.Write(stars[z]);
                //}

            }
            if (line <= 0)
            {
                return null;
            }


            return stars;
        }

        static void print_space(int space)
        {
            
            if (space == 0)
                return;
            Console.Write(" ");

            
            print_space(space - 1);
        }

        static void print_asterisk(int asterisk)
        {
            
            if (asterisk == 0)
                return;
            Console.Write("* ");

            
            print_asterisk(asterisk - 1);
        }

        static void pattern(int n, int num)
        {
            
            if (n == 0)
                return;
            print_space(n - 1);
            print_asterisk(num - n + 1);
            Console.WriteLine("");

            
            pattern(n - 1, num);
        }
    }
}
