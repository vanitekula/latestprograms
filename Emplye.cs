using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class Stud
    {
        int Sid;
        string Sname;
        public Stud(int Sid, string Sname)
        {
            this.Sid = Sid;
            this.Sname = Sname;
        }
        public override string ToString()
        {
            return $"Sid : {Sid}  Sname : {Sname}";
        }
    }
    class Emplye
    {
        int Eid;
        string Ename;
        public Emplye(int Eid,string Ename)
        {
            this.Eid = Eid;
            this.Ename = Ename;
        }
        public override string ToString()
        {
            return $"Eid : {Eid}\tEname : {Ename}";
        }
    }
}
