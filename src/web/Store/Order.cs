using System.Collections.Generic;

namespace web.Store
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public ICollection<Product> Products { get; set; }
        public double OrderTotal { get; set; }
        public string CreditCardNumber { get; set; }

    }
}