using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace ArrayListFunctions
{
   public class ExpandableArray
    {
        public ArrayList arlist1 = new ArrayList();
        public ArrayList add(Object ob)
        {
            
            arlist1.Add(ob);
            return arlist1;
        }

        public ArrayList set(int index, Object ob)
        {
            arlist1[index] = ob;
            return arlist1;
        }

        public string get(int index)
        {
            Console.WriteLine("Content at {0} is {1}", index, arlist1[index]);
            return arlist1[index].ToString();
        }

        public ArrayList print()
        {
            for(int i = 0; i < arlist1.Count; i++)
            {
                Console.WriteLine(arlist1[i]);
                
            }
            return arlist1;
        }
    }
}
