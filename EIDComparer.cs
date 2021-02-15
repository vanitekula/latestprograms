using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiranConsoleApp
{
    class EIDComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee emp1 = (Employee)x ;
            Employee emp2 = y  as Employee;
            if (emp1.eid < emp2.eid)
            {
                return -1;
            }

            if (emp1.eid > emp2.eid)
            {
                return 1;
            }
            return 0;


        }
    }
}
