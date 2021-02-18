using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Class16
    {
        static void Main(string[] args)
        {
            Console.Write("Enter File Name with Location : ");
            StreamWriter sw = new StreamWriter(Console.ReadLine());
            sw.WriteLine("Welcome to Ojas Mr.Hari Jakki");
            sw.Close();

        }
    }
}
