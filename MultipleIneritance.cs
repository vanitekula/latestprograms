using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class AA
    {
       protected int num1;
       protected int num2;
        public void SetValues(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;

        }
        public void ShowValues()
        {
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");
        }
    }
    interface IB
    {
         void Sub();
    }
    interface IC
    {
        void Mul();
    }
    class DD : AA, IB, IC
    {
        public void Div()
        {
            Console.WriteLine($"Quo : {num1/num2}");
        }

        public void Mul()
        {
            Console.WriteLine($"Mul : {num1*num2}");
        }

        public void Sub()
        {
            Console.WriteLine($"Sub : {num1/num2}");
        }
    }
    class MultipleIneritance
    {
        static void Main(string[] args)
        {
            DD p = new DD();
            p.SetValues(5, 3);
            p.ShowValues();
            p.Sub();
            p.Mul();
            p.Div();



        }
    }
}
