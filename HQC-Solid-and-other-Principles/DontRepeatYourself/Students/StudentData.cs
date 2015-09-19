namespace HQC_Solid_and_other_Principles.DontRepeatYourself.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentData
    {
        private IEnumerable<Student> students;

        public StudentData(IEnumerable<Student> students)
        {
            this.students = new HashSet<Student>(students);
        }

        public IEnumerable<Student> OrderedByFirstName()
        {
            return this.OrderByExpression(st => st.FirstName);
        }

        public IEnumerable<Student> OrderByLastName()
        {
            return this.OrderByExpression(st => st.LastName);
        }

        public IEnumerable<Student> OrderByIds()
        {
            return this.OrderByExpression(st => st.Id);
        }

        public IEnumerable<Student> OrderByMarks()
        {
            return this.OrderByExpression(st => st.Mark);
        }

        public IEnumerable<Student> OrderedByAge()
        {
            return this.OrderByExpression(st => st.Age);
        }

        public IEnumerable<Student> OrderedByParticipation()
        {
            return this.OrderByExpression(st => st.Participations);
        }

        public IEnumerable<Student> OrderByExpression<Condition>(Func<Student, Condition> expression)
        {
            if (!this.students.Any())
            {
                throw new InvalidOperationException("There are no students to sort");
            }

            var copiedStudents = new HashSet<Student>(this.students);
            var result = copiedStudents.OrderBy(expression);
            return result;
        }
    }
}
