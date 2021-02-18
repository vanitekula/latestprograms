using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OopsConsoleApp
{
    class Class15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Drive Name : ");
           
            foreach (string s in Directory.GetDirectories(Console.ReadLine()))
            {
                Console.WriteLine(s);
            }

        }
    }
}
