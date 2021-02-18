using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Demo3
    {
        public void Show<T>(T var)
        {
            Console.WriteLine(var);
        }
    }
    class Class10
    {
        static void Main(string[] args)
        {
            new Demo3().Show("aaa");
            new Demo3().Show(345);

        }
    }
}
