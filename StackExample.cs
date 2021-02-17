using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace OopsConsoleApp
{
    class StackExample
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(5);
            s.Push("abc");
            s.Push(true);
            s.Push(6.5);
            Console.WriteLine($"Total elements present in the stack are : {s.Count}");
            foreach(object ob in s)
            {
                Console.WriteLine(ob);
            }
            Console.WriteLine("Peek element in the stack : {0}",s.Peek());
            Console.WriteLine("Deleted element in the stack is : {0}",s.Pop());
            Console.WriteLine($"After deleting the element from the stack Total elements present in the stack are : {s.Count}");
            foreach (object ob in s)
            {
                Console.WriteLine(ob);
            }

        }
    }
}
