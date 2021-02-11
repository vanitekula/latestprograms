using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class OperOver
    {
        int num1;
        int num2;
        public void SetValues(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public void GetValues()
        {
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}");
        }
        public static OperOver operator+(OperOver l,OperOver m)
        {
            OperOver temp = new OperOver();
            temp.num1 = l.num1 + m.num1;
            temp.num2 = l.num2 + m.num2;
            return temp;
        }

    }
    class OperverExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P object");
            OperOver p = new OperOver();
            p.SetValues(100, 200);
            p.GetValues();
            Console.WriteLine("q object");
            OperOver q = new OperOver();
            q.SetValues(500, 1000);
            q.GetValues();
            Console.WriteLine("r object");
            OperOver r = new OperOver();
            r = p + q;
            r.GetValues();

        }
    }
}
