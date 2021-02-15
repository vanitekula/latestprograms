using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace KiranConsoleApp
{

    class Class15
    {
        static void Main(string[] args)
        {
            ArrayList alist = new ArrayList();
            Console.WriteLine(alist.Add(10));
            Console.WriteLine(alist.Add("aaa"));
            Console.WriteLine(alist.Add(true));
            Console.WriteLine(alist.Add(4.5));
            alist.AddRange(new int[]{10,87,56 });
            Console.WriteLine("Array list elements are");
            foreach(object ob in alist)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
