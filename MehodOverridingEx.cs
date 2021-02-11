using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Tesla
    {
        int num1;
        int num2;
        public void ReadValues()
        {
            Console.Write("Enter Number1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Number2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        public void ShowValues()
        {
            Console.WriteLine($"num1 = {num1}\tnum2={num2}");
        }
        public override string ToString()
        {
            return $"num1 = {num1}\tnum2={num2}";
        }

    }
    
    class MehodOverridingEx
    {

        static void Main(string[] args)
        {
            Tesla t = new Tesla();
            t.ReadValues();
          
            Console.WriteLine(t);
            
        }
    }
}
