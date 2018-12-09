using System;

namespace CommerceProject.Model
{
    public interface IPriceRule
    {
        bool IsMatch(OrderItem item);
        decimal CalculatePrice(OrderItem item);
    }
}