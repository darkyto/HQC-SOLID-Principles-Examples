namespace HQC_Solid_and_other_Principles.DependencyInversion.Database
{
    using System;
    using System.Collections.Generic;
    using HQC_Solid_and_other_Principles.DependencyInversion.Database.Contracts;

    public class CourseData : ICourseData
    {
        public IEnumerable<int> CourseIds()
        {
            // return course ids
            return null;
        }

        public IEnumerable<string> CourseNames()
        {
            // return course names
            return null;
        }

        public IEnumerable<string> Search(string substring)
        {
            // return found results
            return null;
        }

        public string GetCourseById(int id)
        {
            // return course by id
            return null;
        }
    }
}
