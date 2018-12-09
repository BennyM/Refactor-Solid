using CommerceProject.Model;

namespace CommerceProject.Services
{
    public interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}