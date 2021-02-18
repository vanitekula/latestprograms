using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OopsConsoleApp
{
    class Class13
    {
        static void Main(string[] args)
        {
            //File.Create("D:/Durga.txt");
            FileInfo finfo = new FileInfo("D:/Durga.txt");
            Console.WriteLine(finfo.Exists);
            Console.WriteLine(finfo.CreationTime);
        }
    }
}
