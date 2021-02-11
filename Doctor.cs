using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Doctor
    {
        string doctorName;
        int doctorFee;
        string speciality;
        public void SetDoctorInfo(string doctorName, int doctorFee, string speciality)
        {
            this.doctorName = doctorName;
            this.doctorFee = doctorFee;
            this.speciality = speciality;
        }
        public void ShowDoctorInfo()
        {
            Console.WriteLine(doctorName);
            Console.WriteLine(doctorFee);
            Console.WriteLine(speciality);
        }

    }
}
