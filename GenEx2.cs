using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Gen2<T1,T2>
    {
        public void Show(T1 p,T2 q)
        {
            Console.WriteLine($"{p}\t{q}");
        }
    }
    class GenEx2
    {
        static void Main(string[] args)
        {
            Gen2<int, double> gen2 = new Gen2<int, double>();
            gen2.Show(45, 6.7);
            Gen2<string, bool> gen21 = new Gen2<string, bool>();
            gen21.Show("aaa", true);
            Emplye emp = new Emplye(111, "Empkiran");
            Stud stud = new Stud(324, "studRaj");
            Gen2<Emplye, Stud> gen22 = new Gen2<Emplye, Stud>();
            gen22.Show(emp, stud);




            
        }
    }
}
