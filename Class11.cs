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

            Mover p = new Mover();
            p.Show(1, 2);
            p.Show("aaa", "bbb");
            p.Show(6.7, 8.9);
        }
    }
}
