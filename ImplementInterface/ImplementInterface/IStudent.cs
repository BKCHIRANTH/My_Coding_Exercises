using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementInterface
{
    interface IStudent
    {
         string[] SportsStudents(string name, string dept, string sport);
         string[] NormalStudents(string name, string dept, string major);
       
    }
}
