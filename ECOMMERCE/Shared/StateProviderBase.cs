using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECOMMERCE.Shared
{
    public class StateProviderBase : ComponentBase
    {
        [Inject]
        public ProtectedLocalStorage ProtectedLocalStore { get; set; }

        public bool hasLoaded { get; set; }


    }
}
