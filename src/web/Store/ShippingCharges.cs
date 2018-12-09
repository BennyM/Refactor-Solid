namespace web.Store
{
    public class ShippingCharges
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public double ShippingCost { get; set; }
    }
}