using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoresHistogram
{
    class Call
    {
        static void Main(string[] args)
        {
            Histogram obj = new Histogram();
            obj.readScores("D:\\Exercise_Problems\\ScoresHistogram\\MidTermScoresText.txt");
            

            Console.ReadLine();
        }
    }
}
