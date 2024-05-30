using System;
using System.Collections.Generic;

namespace szymon.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PaymentMethod { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; }

        public Order()
        {
            Products = new List<Product>();
        }
    }
}
