using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class CheckAdam
    {
        public static bool IsAdam(int num)
        {
            return Squre(num) == Reverse(Squre(Reverse(num)));
        }

        private static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            return rev;
        }

        private static int Squre(int num)
        {
            return num * num;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(IsAdam(12));
            Console.WriteLine(IsAdam(10));
        }
    }
}
