using System;
using System.Collections.Generic;
using System.Text;

namespace RevisionConsole
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num = 5; // 1+2+3+4+5=>15
            int min = 1;
            int sum = 0;
            while(min<=num) // 1<=5
            {
                Console.WriteLine(min);//1
                sum = sum + min;//
                min = min + 1;
            }
            Console.WriteLine("Sum is {0}",sum);
        }
    }
}
