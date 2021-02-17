using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class StackWithOrg
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Ojas:
            Console.Write("1.ADD\n2.DEL\n3.Display\nEnter ur choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();
            
            switch (choice)
            {
                case 1:
                    Console.Write("Enter element to be added : ");
                    string element = Console.ReadLine();
                    s.Push(element);
                    goto Ojas;
                case 2:
                    if (s.Count == 0)
                    {
                        Console.WriteLine("no elements present inside the stack");
                    }
                    else
                    {
                        Console.WriteLine("Deleted element is : {0}", s.Pop());
                    }
                    goto Ojas;
                case 3:
                    Console.WriteLine("Elements in the stack are");
                    if (s.Count == 0)
                    {
                        Console.WriteLine("NO elements present inside the stack");
                    }
                    else
                    {
                        Console.WriteLine("Elements present inside the stack are");
                        foreach (object ob in s)
                        {
                            Console.WriteLine(ob);
                        }
                    }
                    goto Ojas;
                default:
                    Console.WriteLine("Invalid choice....");
                    break;
            }
        }
    }
}
