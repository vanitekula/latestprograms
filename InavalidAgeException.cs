using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class InavalidAgeException : Exception
    {
        public InavalidAgeException()
        {
            Console.WriteLine(this.GetType()+" : Invalid Age");
        }

        
    }
}
