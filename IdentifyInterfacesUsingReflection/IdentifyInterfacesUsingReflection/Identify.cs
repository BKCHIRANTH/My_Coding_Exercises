using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IdentifyInterfacesUsingReflection
{
   public class Identify : IAnimal , IBirds
    {
        public ArrayList getInterfaces(Type t)
        {

            ArrayList interfaces = new ArrayList();
            Console.WriteLine("Interfaces Present:");
            try
            {
                Type[] ifaces = t.GetInterfaces();

                foreach (Type i in ifaces)
                {
                    Console.WriteLine(i.Name);
                    interfaces.Add(i.Name);
                }
            }

            catch (Exception e)
            {
                return null;
            }
        
            
            return interfaces;
        }
        public double animalCost(int nos)
        {
            double res = nos * 10; ;
            return res;
        }

        public int nocages(int birds)
        {
            int cages = birds + 3;
            return cages;
        }
    }
}
