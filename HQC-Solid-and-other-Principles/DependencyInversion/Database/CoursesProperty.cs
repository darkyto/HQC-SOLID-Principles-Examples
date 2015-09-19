namespace HQC_Solid_and_other_Principles.DependencyInversion.Database
{
    using System;
    using System.Collections.Generic;
    using HQC_Solid_and_other_Principles.DependencyInversion.Database.Contracts;

    public class CoursesProperty
    {
        public ICourseData Data { get; set; }

        public void PrintAll()
        {
            var courses = this.Data.CourseNames();
        }

        public void PrintIds()
        {
            var course = this.Data.CourseIds();
        }

        public void PrintById(int id)
        {
            var courses = this.Data.GetCourseById(id);
        }

        public void Search(string substring)
        {
            var courses = this.Data.Search(substring);
        }

        // other methods not needing ICourseData
        public void CalculateResults()
        {
            // do operations without needing ICourseData
        }
    }
}
