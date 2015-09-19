namespace HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape.Contracts;

    public class Square : IShape
    {
        public Square(decimal width)
        {
            this.Width = width;
        }

        public decimal Width { get; set; }

        public decimal Area
        {
            get { return this.Width * this.Width; }
        }
    }
}
