using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Number1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter Number2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Hello I am Divide");
                    }
                    Console.WriteLine(num1 + num2);
                    Console.WriteLine(num1 / num2);
                }
                catch (FormatException fx)
                {
                    Console.WriteLine("Plz Enter only numbers");
                }
                catch(DivideByZeroException dx)
                {
                    Console.WriteLine("num2 can't be zero "+dx.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.GetType());
                }
                finally
                {
                    Console.WriteLine("Thanku visit Again......");
                }
              
            }
        }
    }
}
