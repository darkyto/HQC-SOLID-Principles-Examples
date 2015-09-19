namespace HQC_Solid_and_other_Principles.OpenClosed.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.DrawingShape.Contracts;

    public class RectangleDrawingManager : DrawingManager
    {
        public override void DrawFigure(IShape shape)
        {
            var rectangle = shape as Rectangle;

            // draw logic for rect should follow here
        }
    }
}
