using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddCommasToNumber
{
    class Call
    {
        static void Main(string[] args)
        {
            char choice;
            while(true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Enter Number:");
                String num = Console.ReadLine();

                AddComma addcomma = new AddComma();
                addcomma.addCommasToNumericString(num);

                Console.WriteLine("\n");
                Console.WriteLine("Press q/Q to quit");
                choice = Convert.ToChar(Console.ReadLine());

                if(choice == 'q'|| choice =='Q')
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
