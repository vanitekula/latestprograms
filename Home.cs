using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class Home
    {
        int Capital = 50000;
        public void Spent(int amont)
        {
            Capital = Capital - amont;
            Console.WriteLine($"After spending Balance is {Capital}" );
        }
        public void Balance()
        {
            Console.WriteLine($"Balance is {Capital}");
        }
    }
}
