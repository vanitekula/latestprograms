using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class Class2
    {
        static void Main(string[] args)
        {
            string str = "welcome";
            Console.WriteLine(str.ElementAt(0));//result is char
            Console.WriteLine(str.IndexOf('l'));//result is int
            Console.WriteLine(str.Contains("me"));//boolean
            Console.WriteLine(str.Substring(0));//string
            Console.WriteLine(str.Substring(1));
            Console.WriteLine(str.Substring(2));
            Console.WriteLine(str.Length);//Integer
            Console.WriteLine(str.Substring(0,str.Length));//string
            Console.WriteLine(str.Substring(0, str.Length-1));
            Console.WriteLine(str.Substring(0,str.Length-2));
            string dob = "9-June-1996";
            string[] res =dob.Split('-');//string array
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.WriteLine(res[2]);

            Console.WriteLine("aaaa".CompareTo("aaaa"));
            Console.WriteLine(str.Equals("elcome"));
            Console.WriteLine(string.IsNullOrEmpty(""));



        }
    }
}









