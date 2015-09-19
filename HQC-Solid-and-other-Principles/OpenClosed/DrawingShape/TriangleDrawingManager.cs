namespace HQC_Solid_and_other_Principles.OpenClosed.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.DrawingShape.Contracts;

    public class TriangleDrawingManager : DrawingManager
    {
        public override void DrawFigure(Contracts.IShape shape)
        {
            var triangle = shape as Triangle;
        }
    }
}
