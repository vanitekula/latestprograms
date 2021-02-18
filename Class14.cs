using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OopsConsoleApp
{
    class Class14
    {
        static void Main(string[] args)
        {
            foreach (DriveInfo info in DriveInfo.GetDrives())
            {
                long val = 1024 * 1024 * 1024;
                Console.WriteLine($"{info.Name}\t{info.TotalSize/val} GB\t{info.AvailableFreeSpace/val} GB");
            }

        }
    }
}
