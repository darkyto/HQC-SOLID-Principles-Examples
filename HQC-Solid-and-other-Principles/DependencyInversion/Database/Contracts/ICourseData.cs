namespace HQC_Solid_and_other_Principles.DependencyInversion.Database.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface ICourseData
    {
        IEnumerable<int> CourseIds();

        IEnumerable<string> CourseNames();

        IEnumerable<string> Search(string substring);

        string GetCourseById(int id);
    }
}
