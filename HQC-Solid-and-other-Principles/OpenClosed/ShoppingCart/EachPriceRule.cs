namespace HQC_Solid_and_other_Principles.OpenClosed.ShoppingCart
{
    using System;
    using HQC_Solid_and_other_Principles.OpenClosed.ShoppingCart.Contracts;

    public class EachPriceRule : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            throw new NotImplementedException();
        }

        public decimal CalculatePrice(OrderItem item)
        {
            throw new NotImplementedException();
        }
    }
}
