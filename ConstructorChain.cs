using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Dept
    {
       protected int did;
       protected string dname;
       protected string dloc;
        public Dept(int did,string dname,string dloc)
        {
            this.did = did;
            this.dname = dname;
            this.dloc = dloc;
        }
        public void Show()
        {
            Console.WriteLine($"DeptId : {did}\tDeptName:{dname}\tDeptLoc:{dloc}");
        }
    }
    class Emply :Dept
    {
        int eid;
        string ename;
        int esal;
        public Emply(int eid,string ename,int esal,int did,string dname,string dloc):base(did,dname,dloc)
        {
            this.eid = eid;
            this.ename = ename;
            this.esal = esal;
        }
        public override string ToString()
        {
            return $"Eid : {eid}\tEname : {ename}\tEsal : {esal}\tDeptId : {did}\tDname : {dname}\tDLoc : {dloc}";
        }
    }
    class Class5
    {
        static void Main(string[] args)
        {
            Emply emp = new Emply(111, "aaa", 5000, 23, "Hr", "Hyd");
            Console.WriteLine(emp);
        }
    }
}
