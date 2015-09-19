namespace HQC_Solid_and_other_Principles.OpenClosed.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.DrawingShape.Contracts;

    public abstract class DrawingManager : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            this.DrawFigure(shape);
        }

        public abstract void DrawFigure(IShape shape);
    }
}
