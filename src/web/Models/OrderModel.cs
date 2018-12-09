using System.Collections.Generic;

namespace web.Models
{
    public class OrderModel
    {
        public ICollection<int> Products { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string EmailAddress { get; set; }

        public string DiscountCode { get; set; }
        public string MobilePhone { get; set; }
        public string CreditCardNumber { get; set; }

    }
}