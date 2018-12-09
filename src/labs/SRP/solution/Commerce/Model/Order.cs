using System;

namespace CommerceProject.Model
{
    public abstract class Order
    {
        protected readonly Cart _cart;

        protected Order(Cart cart)
        {
            _cart = cart ?? throw new ArgumentNullException(nameof(cart));
        }

        public virtual void Checkout()
        {
            // log the order in the database
        }
    }
}