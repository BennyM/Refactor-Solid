namespace CommerceProject.Model
{
    public class PoSCashOrder : Order
    {
        public PoSCashOrder(Cart cart)
            : base(cart)
        {
        }
    }
}