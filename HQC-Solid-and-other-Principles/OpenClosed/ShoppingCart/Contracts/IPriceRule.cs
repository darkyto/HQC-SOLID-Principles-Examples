namespace HQC_Solid_and_other_Principles.OpenClosed.ShoppingCart.Contracts
{
    using System;

    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);

        decimal CalculatePrice(OrderItem item);
    }
}
