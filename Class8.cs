using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class Class8
    {

        public static string ListOfPalindrome(int start,int end) // 10,100
        {
            string res = string.Empty;
            for (int i=start; i <= end; i++)
            {
                if (Class7.IsPalindrome(i))
                {
                    res = res + i+",";
                }
            }
            return res.Substring(0,res.Length-1)+".";
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ListOfPalindrome(10,100));
        }
    }
}
