using System;
using System.Collections.Generic;
using System.Text;

namespace Amarket
{
   public class Order
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid CartId { get; set; }
        public Cart Cart { get; set; }

        public Guid StatusId { get; set; }
        public OrderStatus Status { get; set; }

        public Guid PaymentOptionId { get; set; }
        public PaymentOption PaymentOption { get; set; }    
        

    }
}
