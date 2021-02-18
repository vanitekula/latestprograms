using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OopsConsoleApp
{
    class Class17
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name with Location : ");
            string fname = Console.ReadLine();
            Console.WriteLine("========Enter You Inforation======= " );
            StreamWriter sw = new StreamWriter(fname);
            string info = string.Empty;
            while(!string.IsNullOrEmpty(info=Console.ReadLine()))
            {
                sw.WriteLine(info);
            }
            sw.Close();


        }
    }
}
