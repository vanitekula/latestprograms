using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    public delegate void Delegate(int p, int q);
    //accessmodifer delegate returnthype delname(parameters);
    class Demo2
    {
        public void Sum(int x,int y)
        {
            Console.WriteLine($"sum is : {x+y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"sub is : {x - y}");
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"mul is : {x * y}");
        }
    }
    class Class13
    {
        static void Main(string[] args)
        {
            Delegate d1 = new Delegate(new Demo2().Sum);
            Delegate d2 = new Delegate(new Demo2().Sub);
            Delegate d3 = new Delegate(new Demo2().Mul);
            d1(4, 5);
            d2(5, 3);
            d3(6, 2);
            Delegate d4 = d1 + d2 + d3;
            d4(7, 2);
        }
    }
}
