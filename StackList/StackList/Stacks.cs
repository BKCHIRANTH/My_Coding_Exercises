using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace StackList
{
   public class Stacks
    {

       public Stack<string> stack1 = new Stack<string>();
        

        public void addItems(string item )
        {
            stack1.Push(item);
            
        }

        public void removeItems()
        {
            Console.WriteLine("Item Removed");
            stack1.Pop();
        }

        public void topItem()
        {
            Console.WriteLine("Top in the stack: "+stack1.Peek());
        }

        public String[] display()
        {
            String[] result = new String[stack1.Count];
            int cnt = 0;
            foreach (string s in stack1)
            {
                Console.WriteLine(s);
                result[cnt++] = s;
            }

            return result;
        }
    }
}
