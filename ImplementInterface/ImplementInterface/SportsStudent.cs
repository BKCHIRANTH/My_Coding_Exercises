using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    public class SportsStudent : StudentAbstract
    {
        public double excuse;
        public override string Achievements(string achieve)
        {
            Console.WriteLine("Achievements : {0}", achieve);
            return achieve;
        }

        public double Excusehours(double totalhours)
        {
            this.excuse = totalhours * 3;
            Console.WriteLine("Exempted for {0} hours", this.excuse);
            return this.excuse;
        }
    }
}
