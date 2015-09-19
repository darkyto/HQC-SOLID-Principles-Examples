namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Employees
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Employee
    {
        private string name;

        public Employee(string name)
        { 
            this.Name = name;
        }

        public string Name 
        { 
            get 
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + this.Name;
        }
    }
}
