namespace Tests
{
    using System;
    using System.Collections.Generic;
    using HQC_Solid_and_other_Principles.DependencyInversion.Database;
    using HQC_Solid_and_other_Principles.DependencyInversion.HelloWorld;
    using HQC_Solid_and_other_Principles.DontRepeatYourself.Students;
    using HQC_Solid_and_other_Principles.LiskovSubstitution.Employees;
    using HQC_Solid_and_other_Principles.LiskovSubstitution.Shapes;
    using NUnit.Framework;

    public class UnitTest1
    {
        [Test]
        public void ValidStudentsCollectionNotEmptyAfterSortByIDs()
        {
            var st1 = new Student(425, "Nikolay", "Iliev", 35);
            var st2 = new Student(055, "Stefan", "Zahariev", 22);
            var st3 = new Student(758, "Maria", "Ivanova", 30);
            var st4 = new Student(124, "Petia", "Grigorova", 17);
            var st5 = new Student(001, "Grigor", "Stefanov", 25);

            HashSet<Student> students = new HashSet<Student> { st1, st2, st3, st4, st5 };

            var data = new StudentData(students);
            var orderedStudents = data.OrderByIds();

            CollectionAssert.IsNotEmpty(orderedStudents);
        }

        [Test]
        public void ValidGreeings()
        {
            var greeter = new HelloWorld(DateTime.Now);
            var greeting = greeter.Greet("John");
            Assert.That(greeting, Contains.Substring("Good"));
        }

        [Test]
        public void SquareAreaShouldWork()
        {
            Shape shape = new Square(5);
            var area = shape.Area;
            Assert.AreEqual(25, area);
        }

        [Test]
        public void SquareAreaNotEqual()
        {
            Shape shape = new Square(5);
            var area = shape.Area;
            Assert.AreNotEqual(26, area);
        }

        [Test]
        public void RectangleAreaShouldWork()
        {
            var rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 4;
            var area = rect.Area;
            Assert.AreEqual(20, area);
        }

        [Test]
        public void CreateNewManagerShouldWork()
        {
            var boss = new Manager("Steeve Jobs");
            string[] arr = new string[3]; // New array with 3 elements.
            arr[0] = "top";
            arr[1] = "middle";
            arr[2] = "bottom";
            boss.Documents = new List<string>(arr);
            boss.ToString();
        }

        [Test]
        public void CreateEmployeesDetails()
        {
            var boss = new Manager("Steeve");
            var boss2 = new Manager("Maria");
            var driver = new Employee("Stamat");

            var employees = new List<Employee>();
            employees.Add(boss);
            employees.Add(boss2);
            employees.Add(driver);

            var pr = new DetailsPrinter(employees);
            pr.Print();        
        }
    }
}
