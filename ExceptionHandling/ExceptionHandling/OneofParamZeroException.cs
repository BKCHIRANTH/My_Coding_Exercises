using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class OneofParamZeroException : Exception
    {
        public OneofParamZeroException(string message) : base(message)
        {
        }
    }
}
