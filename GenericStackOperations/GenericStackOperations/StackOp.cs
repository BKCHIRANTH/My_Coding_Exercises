using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GenericStackOperations
{
   public class StackOp
    {
        Stack<object> myStack = new Stack<object>();
        public bool insertStack(object value)
        {
            if (value == null)
            {
                return false;
            }
            myStack.Push(value);
            return true;
        }

        public object deleteStack()
        {
            if (myStack.Count == 0)
            {
                Console.WriteLine("No elements");
                return null;
            }
           var delElement = myStack.Pop();
            Console.WriteLine("{0} is popped!", delElement);
            return delElement;
        }

        public object topStack()
        {
            if (myStack.Count == 0)
            {
                Console.WriteLine("No elements");
                return null;
            }
            var top = myStack.Peek();
            Console.WriteLine("On top of stack: {0}", top);
            return top;
        }

        public bool checkExist(object value)
        {
            if (myStack.Contains(value))
            {
                Console.WriteLine("{0} exists in the stack",value);
                return true;
            }
           
            Console.WriteLine("{0} does not exist in the stack", value);
            return false;
        }

        public ArrayList displayStack()
        {
            ArrayList values = new ArrayList();
            if (myStack.Count == 0)
            {
                Console.WriteLine("No elements");
                return null;
            }

            
            Console.WriteLine("Contents of Stack:");
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
                values.Add(item);
            }
            return values;
        }

        public bool isEmpty()
        {
            if(myStack.Count == 0)
            {
                Console.WriteLine("Stack is empty!");
                return true;
            }
            else
            {
                Console.WriteLine("Stack contains {0} elements", myStack.Count);
                return false;
            }
        }
        
        public bool clearOut()
        {
            if (myStack.Count == 0)
            {
                Console.WriteLine("No elements");
                return false;
            }
            myStack.Clear();
            return true;
        }
    }
}
