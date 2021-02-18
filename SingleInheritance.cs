using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class BasicCalcy
    {
        public void Sum(int x,int y)
        {
            Console.WriteLine("Sum is : {0}",x+y);
        }
        public void Sub(int x,int y)
        {
            Console.WriteLine("Sub is : {0}", x - y);
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("Mul is : {0}", x*y);
        }
    }
  sealed  class SciCaly:BasicCalcy
    {
        public void Cos(int x)
        {
            Console.WriteLine(Math.Cos(x));
        }
        public void Sine(int x)
        {
            Console.WriteLine(Math.Sin(x));
        }
    }
    class SingleInheritance
    {
        static void Main(string[] args)
        {
            SciCaly s = new SciCaly();
            s.Cos(0);
            s.Sine(90);
            s.Sum(6, 2);
            s.Sub(8, 4);
            
        }
    }
}
