using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class Class7
    {
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                int digit = num % 10;
                rev = rev * 10 + digit;
                num = num / 10;
            }
            return rev;
        }
        public static bool IsPalindrome(int num) // 121
        {
            
            return num == Reverse(num);
        }





        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(123));
            Console.WriteLine(IsPalindrome(121));
        }
    }
}
