using System.Collections.Generic;
using CommerceProject.Model;

namespace CommerceProject.Services
{
    public interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}