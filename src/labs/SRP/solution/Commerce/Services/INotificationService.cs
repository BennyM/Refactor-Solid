using CommerceProject.Model;

namespace CommerceProject.Services
{
    internal interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}