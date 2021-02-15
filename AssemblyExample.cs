using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OjasSystemm;
namespace KiranConsoleApp
{
    class Class14
    {
        static void Main(string[] args)
        {
            OjasConsole.ShowLine("welcome to ojas");
            OjasConsole.ShowLine("Hi this is .net Traiining");
            new OjasConsole().DisplayLine("Hi Guys");
            new OjasConsole().DisplayLine("Good evening");
            Console.WriteLine(new CheckNums().Reverse(123));
            Console.WriteLine(new CheckNums().IsPalindrome(123));
            Console.WriteLine(new CheckNums().IsPalindrome(121));
            new OILC102().ShowResult();
        }
    }
}
