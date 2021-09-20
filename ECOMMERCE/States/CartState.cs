using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE
{
    public class CartState : ComponentBase
    {
       
        public Guid CartId { get; set; } = Guid.Empty;

        public CartState()
        {
            if (CartId.Equals(Guid.Empty)) {
                CartId = Guid.NewGuid();
            }
        }
        public void SetCartId(ComponentBase source, object cartId)
        {
            this.CartId = Guid.Parse(cartId.ToString());
            NotifyStateChanged(source, cartId);
        }

        public  event Action<ComponentBase, object> StateChanged;
        private  void NotifyStateChanged(ComponentBase source, object property) => StateChanged?.Invoke(source, property);
    }
}
