using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class Class4
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
        public static  int  Sum(int num1,int num2) //defined
        {
          return  num1 + num2;
        }

        static void Main(string[] args)
        {
            int res = Sum(5, 6);
            Console.WriteLine(res);
            Console.WriteLine(Sum(8,7));
            int x = Reverse(123);
            Console.WriteLine(x);
            Console.WriteLine(Reverse(456));
        }
    }
}





