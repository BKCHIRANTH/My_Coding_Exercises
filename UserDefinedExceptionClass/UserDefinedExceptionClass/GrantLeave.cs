using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptionClass
{
    public class GrantLeave
    {
        public bool GrantingLeaves(int leaves)
        {
            try
            {
                if (leaves <= 0)
                {
                    throw (new OutofLeavesException("Please enter valid no of days!"));
                }

                else if (leaves <= 3)
                {
                    Console.WriteLine("Congratulations! you are granted with {0} days of leave!",leaves);
                    return true;
                }
                
                else
                {
                    throw (new OutofLeavesException("Cannot apply for leave more than 3 days!"));
                    
                }
            }

            catch (OutofLeavesException ole)
            {
                Console.WriteLine(ole.Message.ToString());
            }

            return false;
        }
    }
}
