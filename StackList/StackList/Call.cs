using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackList
{
    class Call
    {
        static void Main(string[] args)
        {
            Stacks st = new Stacks();

            st.addItems("CSE");
            st.addItems("ISE");
            st.addItems("ME");
            st.addItems("ECE");
            st.addItems("EEE");


           
            st.topItem();
            st.removeItems();

            st.display();

            Console.ReadLine();
        }
    }
}
