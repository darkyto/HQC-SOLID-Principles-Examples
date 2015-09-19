namespace HQC_Solid_and_other_Principles.DependencyInversion.Database
{
    using System;
    using System.Collections.Generic;
    using HQC_Solid_and_other_Principles.DependencyInversion.Database.Contracts;

    public class CoursesParameter
    {
        public void PrintAll(ICourseData data)
        {
            var courses = data.CourseNames();
        }

        public void PrintIds(ICourseData data)
        {
            var courses = data.CourseIds();

            // print courses
        }

        public void Seatch(ICourseData data, string substring)
        {
            var course = data.Search(substring);

            // print courses
        }

        // other methods not needing ICourseData
        public void CalculateResults()
        {
            // do operations without needing ICourseData
        }
    }
}
