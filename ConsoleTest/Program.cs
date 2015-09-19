namespace ConsoleTest
{
    using System;
    using System.Collections.Generic;
    using HQC_Solid_and_other_Principles.DontRepeatYourself.Students;

    public class Program
    {
        public static void Main(string[] args)
        {
            var st1 = new Student(425, "Nikolay", "Iliev", 35);
            var st2 = new Student(055, "Stefan", "Zahariev", 22);
            var st3 = new Student(758, "Maria", "Ivanova", 30);
            var st4 = new Student(124, "Petia", "Grigorova", 17);
            var st5 = new Student(001, "Grigor", "Stefanov", 25);

            HashSet<Student> students = new HashSet<Student>();
            students.Add(st1);
            students.Add(st2);
            students.Add(st3);
            students.Add(st4);
            students.Add(st5);

            var data = new StudentData(students);
            var orderedStudents = data.OrderedByFirstName();
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName);
            }

            orderedStudents = data.OrderedByAge();
            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student.FirstName + " is " + student.Age + " years old");
            }
        }
    }
}
