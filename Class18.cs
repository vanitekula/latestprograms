using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Class18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name :");
            string fname = Console.ReadLine();
            System.IO.StreamReader sr = new System.IO.StreamReader(fname);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}
