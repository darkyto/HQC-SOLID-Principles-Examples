namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Shapes
{
    using System;

    public class Rectangle : Shape
    {
        public virtual decimal Width { get; set; }

        public virtual decimal Height { get; set; }

        public override decimal Area
        {
            get { return this.Width * this.Height; }
        }
    }
}
