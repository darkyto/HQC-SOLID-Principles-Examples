namespace HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape
{
    using System;
    using HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape.Contracts;

    public class DrawingManager : IDrawingManager
    {
        private readonly IDrawingContext drawingContext;
        private readonly IRenderer renderer;

        public DrawingManager(IDrawingContext drawingContext, IRenderer renderer)
        {
            this.drawingContext = drawingContext;
            this.renderer = renderer;
        }

        public void Draw(IShape shape)
        {
            this.renderer.Render(this.drawingContext, shape);
        }
    }
}
