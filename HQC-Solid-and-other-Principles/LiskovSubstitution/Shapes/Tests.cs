namespace HQC_Solid_and_other_Principles.LiskovSubstitution.Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    public class Tests
    {
        [Test]
        public void SquareAreaShouldWork()
        {
            Shape shape = new Square(5);
            var area = shape.Area;
            Assert.AreEqual(25, area);
        }
    }
}
