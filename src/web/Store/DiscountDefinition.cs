namespace web.Store
{
    public class DiscountDefinition
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public double? FlatDiscountAmount { get; set; }
        public double? DiscountPercentage { get; set; }
        public bool? FreeShipping { get; set; }
    }
}