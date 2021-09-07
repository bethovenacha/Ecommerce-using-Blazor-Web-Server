using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Amarket
{
   public class Cart
    {
      
        public Guid Id { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid CartId { get; set; }

        [ForeignKey("Products")]
        public Guid ProductId { get; set; }
        public Product Products { get; set; }

        public double Quantity { get; set; }

        public double Price { get; set; }

        public double Tax { get; set; }

        public double ShipmentFee { get; set; }

        public double Total { get; set; }
        public Order Order { get; set; }

       
    }
}
