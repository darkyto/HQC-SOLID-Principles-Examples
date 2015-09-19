namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Employees
{
    using System;
    using System.Collections.Generic;

    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public IEnumerable<string> Documents { get; set; }

        public override string ToString()
        {
            // todo join the documents
            return base.ToString() + "; Documents: ";
        }
    }
}
