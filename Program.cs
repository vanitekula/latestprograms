using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Employee
    {
       int empId;
       string empName;  //Instance members
       int empSal;
       public void SetEmpInfo(int id,string ename,int esal) //Assigning the data
        {
            empId = id;
            empName = ename;
            empSal = esal;
        }
        public void ShowEmpInfo()
        {
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSal);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetEmpInfo(111, "abc", 50000);
            emp.ShowEmpInfo();
            
        }
    }
}
