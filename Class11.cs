using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class Mover
    {
        public void Show(int x,int g)
        {
           
            Console.WriteLine($"{x} {g}");
        }
        public void Show(string x, string g)
        {

            Console.WriteLine($"{x} {g}");
        }
        
        public void Show(double x, double g)
        {

            Console.WriteLine($"{x} {g}");
        }
    }
    class Class11
    {
        static void Main(string[] args)
        {
            new Mover().Show(5,6);
            new Mover().Show("aaa", "bbbb");
            new Mover().Show(6.7, 4.5);
        }
    }
}
