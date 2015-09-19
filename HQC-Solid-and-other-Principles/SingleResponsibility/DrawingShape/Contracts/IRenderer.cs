namespace HQC_Solid_and_other_Principles.SingleResponsibility.DrawingShape.Contracts
{
    public interface IRenderer
    {
        void Render(IDrawingContext context, IShape shape);
    }
}
