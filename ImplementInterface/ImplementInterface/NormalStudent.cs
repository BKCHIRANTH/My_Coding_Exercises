using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
   public class NormalStudent : StudentAbstract
    {
        public int grace;
        public override string Achievements(string achieve)
        {
            Console.WriteLine("Achievements : {0}", achieve);
            return achieve;
        }

        public int GraceCalculate(int noPaper)
        {
            this.grace = noPaper + 10;
            Console.WriteLine("Grace points obtained: {0}", this.grace);
            return this.grace;
        }

    }
}
