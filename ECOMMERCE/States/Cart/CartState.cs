using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE
{
    public class CartState
    {
        public Guid CartId { get; set; } = Guid.Empty;

        //public delegate void StateChanged(ComponentBase source, string property);

        //public event StateChanged OnChange;

        public void UpdateCartId(ComponentBase source, object property) {
            this.CartId = Guid.Parse(property.ToString());
            NotifyStateChanged(source, property);
        }

        public event Action<ComponentBase, object> StateChanged;
        private void NotifyStateChanged(ComponentBase source, object property) => StateChanged?.Invoke(source, property);
    }
}
