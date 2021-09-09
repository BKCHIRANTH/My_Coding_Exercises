using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APAndGP
{
    public class APGP
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the of the desired progression: 1.AP 2.GP");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the first term");
            int first = Convert.ToInt32(Console.ReadLine());
            int ratio = 0, difference = 0;
            APGP progression = new APGP();

            if (num == 1)
            {
                Console.WriteLine("Enter the common difference");
                difference = Convert.ToInt32(Console.ReadLine());
            }

           else  if (num == 2)
            {
                Console.WriteLine("Enter the common ratio");
                ratio = Convert.ToInt32(Console.ReadLine());
            }

            

            else
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Enter the no of required terms");
            int terms = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
            {
                int[] returnedAP1 = progression.ArithmeticProgression(first, difference, terms);
                Console.WriteLine("Required Progression");
                for (int i = 0; i < returnedAP1.Length; i++)
                {
                    Console.Write(" " + returnedAP1[i]);
                }

                if (returnedAP1 == null)
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            if (num == 2)
            {
                int[] returnedGP = progression.GeometricProgression(first, ratio, terms);
                Console.WriteLine("Required Progression");
                for (int i = 0; i < returnedGP.Length; i++)
                {
                    Console.Write(" " + returnedGP[i]);
                }
                if (returnedGP == null)
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            
            Console.ReadLine();

        }
        
        public int[] GeometricProgression(int firstTerm, int cRatio, int noTerms)
        {
            int[] result = new int[noTerms];
            int currentTerm;

            if (firstTerm != 0 && cRatio != 0 && noTerms != 0)
            {
                for (int i = 0; i < noTerms; i++)
                {
                    currentTerm = firstTerm * (int)Math.Pow(cRatio, i);

                    result[i] = currentTerm;
                }

            }

            else if (firstTerm != (int)firstTerm || cRatio != (int)cRatio || noTerms != (int)noTerms)    //check if any other is entered
            {
                return null;
            }

            else
            {
                return null;
            }

            return result;
        }

        public int[] ArithmeticProgression(int firstterm, int cDifference, int noTerm)
        {
            int[] result1 = new int[noTerm];

            if (cDifference != 0 && noTerm != 0)
            {
                int curr_term;
                int cnt = 0;
                curr_term = firstterm;
                for (int i = 1; i <= noTerm; i++)
                {
                    result1[cnt++] = curr_term;
                    curr_term = curr_term + cDifference;

                }

            }

            else if (firstterm != (int)firstterm || cDifference != (int)cDifference || noTerm != (int)noTerm)    //check if any other character is entered
            {
                return null;
            }

            else
            {
                return null;
            }
            return result1;
        }
    }
}
