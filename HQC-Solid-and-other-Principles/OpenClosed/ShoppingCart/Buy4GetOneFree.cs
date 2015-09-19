namespace HQC_Solid_and_other_Principles.OpenClosed.ShoppingCart
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using HQC_Solid_and_other_Principles.OpenClosed.ShoppingCart.Contracts;

    public class Buy4GetOneFree : IPriceRule
    {
        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("B4GO");
        }

        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quantity * 1m;
            int setsOfFive = item.Quantity / 5;
            total -= setsOfFive * 1m;
            return total;
        }
    }
}
