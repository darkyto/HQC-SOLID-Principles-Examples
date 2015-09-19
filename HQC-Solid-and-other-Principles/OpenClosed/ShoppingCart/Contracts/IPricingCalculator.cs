namespace HQC_Solid_and_other_Principles.OpenClosed.ShoppingCart.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
