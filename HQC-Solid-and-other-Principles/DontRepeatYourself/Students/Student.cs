namespace HQC_Solid_and_other_Principles.DontRepeatYourself.Students
{
    using System;

    public class Student
    {
        private int id;
        private string firstName;
        private string lastName;
        private int age;

        public Student(int id, string firstName, string lastName, int age)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public int Id
        {
            get 
            { 
                return this.id; 
            }

            set 
            {
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public double Mark { get; set; }

        public int Participations { get; set; }
    }
}
