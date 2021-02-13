using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class CustomizedExceptionEx
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter Age:");
                int age = int.Parse(Console.ReadLine());
                if (age < 0 || age > 200)
                {
                    throw new InavalidAgeException();
                }
            }
        }
    }
}
