namespace HQC_Solid_and_other_Principles.DependencyInversion.Database
{
    using System;
    using System.Collections.Generic;
    using HQC_Solid_and_other_Principles.DependencyInversion.Database.Contracts;

    public class CoursesConstructor
    {
        private ICourseData data;

        public CoursesConstructor()
            : this(new CourseData())
        {
        }

        public CoursesConstructor(ICourseData data)
        {
            this.data = data;
        }

        public void PrintAll()
        {
            var courses = this.data.CourseNames();

            // print courses
        }

        public void PrintIds()
        {
            var courses = this.data.CourseIds();

            // print courses
        }

        public void Search(string substring)
        {
            var courses = this.data.Search(substring);

            // print courses
        }

        public void CalculateResults()
        {
            // do operations without needing ICourseData
        }
    }
}
