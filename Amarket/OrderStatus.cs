using System;
using System.Collections.Generic;
using System.Text;

namespace Amarket
{
    public class OrderStatus
    {
        public Guid Id { get; set; }
        public string Status { get; set; }
        public Order Order { get; set; }
    }
}
