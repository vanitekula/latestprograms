using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{



    class Class9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brother1 Operations");
            Home bro1 = new Home();
            bro1.Balance();
            bro1.Spent(10000);
            Console.WriteLine("Brother2 Operations");
            Home bro2 = new Home();
            bro2.Balance();

        }
    }
}
