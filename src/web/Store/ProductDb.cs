using System.Collections.Generic;

namespace web.Store
{
    public class ProductDb
    {
        public List<ShippingCharges> ShippingCharges { get; set; }
        public List<Product> Products { get; set; }
        public List<DiscountDefinition> Discounts { get; set; }
    }
}