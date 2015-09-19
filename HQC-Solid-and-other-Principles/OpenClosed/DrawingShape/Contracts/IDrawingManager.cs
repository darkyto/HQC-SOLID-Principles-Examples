namespace HQC_Solid_and_other_Principles.OpenClosed.DrawingShape.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDrawingManager
    {
        void Draw(IShape shape);
    }
}
