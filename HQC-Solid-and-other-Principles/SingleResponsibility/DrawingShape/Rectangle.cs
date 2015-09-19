namespace HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape.Contracts;

    public class Rectangle : IShape
    {
        public Rectangle(decimal width, decimal height)
        {
            this.Width = width;
            this.Height = height;
        }

        public decimal Width { get; set; }

        public decimal Height { get; set; }

        public decimal Area
        {
            get { return this.Width * this.Height; }
        }
    }
}
