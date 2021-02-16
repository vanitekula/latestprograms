using System;
using System.Collections.Generic;
using System.Text;

namespace RevisionConsole
{
    class Class2
    {
        static void Main(string[] args)
        {
            List<Student> slist = new List<Student>();
            slist.AddRange(new Student[]{
                new Student() { StudentId=11,StudentName="aaa",Marks=750},
                new Student() { StudentId = 12, StudentName = "bbb", Marks = 450 },
                new Student() { StudentId = 10, StudentName = "ddd", Marks = 550 }
                }   );

            foreach(Student student in slist)
            {
                Console.WriteLine(student);
            }
            slist.Sort();
            Console.WriteLine("after sorting");
            foreach (Student student in slist)
            {
                Console.WriteLine(student);
            }

        }
    }
}
