using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class switchexa
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            back:
            Console.Write("1.ADD\n2.SUB\n3.MUL\nEnter ur choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine($"sum is {num1+num2}");
                    goto back;
                case 2:
                    Console.WriteLine($"Chirangivi is {num1 - num2}");
                    goto back;
                case 3:
                    Console.WriteLine($"Kamalhasan is {num1 * num2}");
                    goto back;
                default:
                    Console.WriteLine("Invalid choice...");
                    break;
            }
            
        }
    }
}
