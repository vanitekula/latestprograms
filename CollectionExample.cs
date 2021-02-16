using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace RevisionConsole
{
    class Student:IComparable<Student>
    {


        public int StudentId { get; set; }
        public string StudentName { get; set; }
         public int Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.StudentId < other.StudentId)
            {
                return -1;
            }
            if (this.StudentId > other.StudentId)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return $"{StudentId}\t{StudentName}\t{Marks}";
        }

    }
    class CollectionExample
    {
        static void Main(string[] args)
        {

            SortedSet<int> set = new SortedSet<int>();
           
            set.Add(5);
            set.Add(1);
            set.Add(3);
            set.Add(4);
            set.Add(2);
            set.Add(2);
            foreach(int i in set)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}


