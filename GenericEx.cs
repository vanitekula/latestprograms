using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Gen<T>
    {
        public void Show(T x, T y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }

    }
    class GenericEx
    {
       
        static void Main(string[] args)
        {
            Gen<int> p = new Gen<int>();
            p.Show(5, 6);
            Gen<string> s = new Gen<string>();
            s.Show("aaa", "bbb");
            Gen<double> d = new Gen<double>();
            d.Show(5.6, 7.8);
        }
    }
}
