namespace CommerceProject.Model
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}