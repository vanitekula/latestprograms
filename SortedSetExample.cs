using System;
using System.Collections.Generic;
using System.Text;

namespace RevisionConsole
{
    class SortedSetExample
    {
        static void Main(string[] args)
        {
            SortedSet<Student> studentset = new SortedSet<Student>();
            studentset.Add(new Student() { StudentId = 10, StudentName = "kiran", Marks = 400 });
            studentset.Add(new Student() { StudentId = 8, StudentName = "Raj", Marks = 450 });
            studentset.Add(new Student() { StudentId = 9, StudentName = "Greeshma", Marks = 450 });
            studentset.Add(new Student() { StudentId = 11, StudentName = "Harish", Marks = 400 });
            foreach(Student student in studentset)
            {
                Console.WriteLine(student);
            }
        }

    }
}
