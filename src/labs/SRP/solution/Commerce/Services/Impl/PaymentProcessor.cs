using System;
using CommerceProject.Model;

namespace CommerceProject.Services
{
    internal class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}