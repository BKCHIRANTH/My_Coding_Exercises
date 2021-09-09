using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStackOperations
{
    class Call
    {
        static void Main(string[] args)
        {
            StackOp stackobj = new StackOp();

            stackobj.insertStack("hello");
            stackobj.insertStack("watch over");
            stackobj.insertStack("Russia");
            stackobj.insertStack("grace");
            stackobj.insertStack("tall");
            stackobj.insertStack(5428);
            stackobj.insertStack('A');

            stackobj.displayStack();
            Console.Write("\n");

            stackobj.deleteStack();
            stackobj.displayStack();
            Console.Write("\n");

            stackobj.checkExist("Russia");
            stackobj.checkExist(5428);
            stackobj.checkExist('A');
            Console.Write("\n");

            Console.WriteLine("Before clearing out the stack:");
            stackobj.isEmpty();
            Console.Write("\n");

            Console.WriteLine("After clearing out the stack:");
            stackobj.clearOut();
            stackobj.isEmpty();

            Console.ReadLine();

        }
    }
}
