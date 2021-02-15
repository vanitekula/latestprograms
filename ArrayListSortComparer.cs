using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace KiranConsoleApp
{
    class EnameCompare : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee emp1 = (Employee)x;
            Employee emp2 = (Employee)y;
            return emp1.ename.CompareTo(emp2.ename);
        }
    }
    class Employee
    {
      public  int eid;
      public  string ename;
      public  int esal;
        public Employee()
        {

        }
        public Employee(int eid,string ename,int esal)
        {
            this.eid = eid;
            this.ename = ename;
            this.esal = esal;
        }
        public override string ToString()
        {
            return $"{eid}\t{ename}\t{esal}";
        }
    }
    class Class17
    {
        static void Main(string[] args)
        {
            ArrayList emplist = new ArrayList();
            emplist.Add(new Employee(111,"kkk",45000));
            emplist.Add(new Employee(141, "sss", 55000));
            emplist.Add(new Employee(121, "bbb", 25000));
            emplist.Add(new Employee(110, "aaa", 50000));
            Console.WriteLine("Employees Details");
            foreach(Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("Displaying the elements after sorting");

            // emplist.Sort(new EIDComparer());
            emplist.Sort(new EnameCompare());
            foreach (Employee emp in emplist)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
