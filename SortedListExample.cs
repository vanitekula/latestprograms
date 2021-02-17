using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp
{
    class SortedListExample
    {
        static void Main(string[] args)
        {
            SortedList<int, string> employee = new SortedList<int, string>();
            employee.Add(12, "kiran");
            employee.Add(13, "Greeshma");
            employee.Add(10,"pooja");
            employee.Add(9, "bhuvana");
            employee.Add(8,"durga");
            employee.Add(6, "manikanta");
            employee.Add(5, "hari");
            employee.Add(4, "edukondalu");
            employee.Add(3, "edukondalu");
            Console.WriteLine("Displaying keys ");
            foreach(int key in employee.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("Displaying values");
            foreach(string s in employee.Values)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Displaying key vaues pairs");
            foreach(KeyValuePair<int,string> keyValuePair in employee)
            {
                Console.WriteLine(keyValuePair);
            }
            Console.WriteLine("Displaying key vaues pairs using keys");
            foreach(int key in employee.Keys)
            {
                Console.WriteLine($"{key}\t{employee[key]}");
            }
            if (employee.ContainsKey(3))
            {
                Console.WriteLine(employee[3]);
            }
            Console.WriteLine(employee.Remove(3));
            Console.WriteLine("Displaying key vaues pairs");
            foreach (KeyValuePair<int, string> keyValuePair in employee)
            {
                Console.WriteLine(keyValuePair);
            }
        }
    }
}
