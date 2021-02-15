using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace KiranConsoleApp
{
    class Class16
    {
        static void Main(string[] args)
        {
            ArrayList nameslist = new ArrayList();
            nameslist.Add("kiran");
            nameslist.Add("harish");
            nameslist.Add("vamshi");
            nameslist.Add("greeshma");
            nameslist.Add("bhuvana");
            nameslist.Add("pooja");
            nameslist.Add("durga");
            nameslist.Add("madhu");
            nameslist.Add("manikanta");
            nameslist.Add("edukondalu");
            foreach (string s in nameslist)
            {
                Console.WriteLine(s);
            }
            nameslist.Sort();
            nameslist.Reverse();
            Console.WriteLine("Elements after soring");
            foreach(string s in nameslist)
            {
                Console.WriteLine(s);
            }
            
        }
    }
}
