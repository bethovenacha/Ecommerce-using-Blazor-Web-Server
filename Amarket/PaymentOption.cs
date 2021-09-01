using System;
using System.Collections.Generic;
using System.Text;

namespace Amarket
{
    public class PaymentOption
    {
        public Guid Id { get; set; }
        public string OptionName { get; set; }
        public string OptionValue { get; set; }
        public Order Order { get; set; }
    }
}
