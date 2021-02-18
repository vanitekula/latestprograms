using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Class1
    {
        static void Main(string[] args)
        {
            Doctor Ramesh = new Doctor();
            Ramesh.SetDoctorInfo("Ramesh", 1000, "Phy");
            Ramesh.ShowDoctorInfo();
        }
    }
}
