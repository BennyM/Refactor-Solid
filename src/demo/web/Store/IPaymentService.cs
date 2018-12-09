namespace web.Store
{
    public interface IPaymentService
    {
        void Charge(Order order, double amount);
    }
}