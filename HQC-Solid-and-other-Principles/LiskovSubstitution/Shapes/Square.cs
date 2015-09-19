namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square : Shape
    {
        public Square(decimal side)
        {
            this.Side = side;
        }

        public decimal Side { get; set; }

        public override decimal Area
        {
            get { return this.Side * this.Side; }
        }   
    }
}
