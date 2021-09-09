using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE
{
    public class CartState : ComponentBase
    {
        public List<Amarket.Cart> Cart { get; set; } = new List<Amarket.Cart>();
        public Guid CartId { get; set; } = Guid.Empty;

        public  string key { get; set; } = "";

        public ComponentBase source { get; set; } = null;
        //public delegate void StateChanged(ComponentBase source, string property);

        public CartState()
        {
            if (CartId.Equals(Guid.Empty)) {
                CartId = Guid.NewGuid();
            }
            
            key = "CartId";
            source = this;
        }

        //public event StateChanged OnChange;
        public void SetCart(ComponentBase source, List<Amarket.Cart> _cart) {
            this.Cart = _cart;
            NotifyStateChanged(source, _cart);
        }
        public void SetCartId(ComponentBase source, object property)
        {
            this.CartId = Guid.Parse(property.ToString());
            NotifyStateChanged(source, property);
        }

        public  event Action<ComponentBase, object> StateChanged;
        private  void NotifyStateChanged(ComponentBase source, object property) => StateChanged?.Invoke(source, property);
    }
}
