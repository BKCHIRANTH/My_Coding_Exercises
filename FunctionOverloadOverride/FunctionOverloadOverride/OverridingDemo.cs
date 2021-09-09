using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloadOverride
{
   public class OverridingDemo : OverloadingDemo
    {
        public override int Volume(int param)
        {
            int vol = param * param;
            Console.WriteLine("Volume= " + vol + " cubic mts");
            return vol;
        }
    }
}
