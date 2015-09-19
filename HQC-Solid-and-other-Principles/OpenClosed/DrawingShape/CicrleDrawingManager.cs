namespace HQC_Solid_and_other_Principles.OpenClosed.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.DrawingShape.Contracts;

    public class CicrleDrawingManager : DrawingManager
    {
        public override void DrawFigure(IShape shape)
        {
            var circle = shape as Circle;

            // draw circle logic should follow here..
        }
    }
}
