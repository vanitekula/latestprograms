using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class PartialClassExample
    {
        static void Main(string[] args)
        {
            Bank p = new Bank();
            p.WithDraw();
            p.CheckBalance();
            p.MiniStatement();
        }
    }
}
