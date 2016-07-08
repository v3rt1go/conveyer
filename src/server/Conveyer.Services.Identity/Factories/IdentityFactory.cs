using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveyer.Services.Identity.Factories.Interfaces;
using Conveyer.Services.Identity.Interfaces;
using Conveyer.Services.Identity.Providers;

namespace Conveyer.Services.Identity.Factories
{
    public class IdentityFactory : IIdentityFactory
    {
        public IUserIdentity CreateIdentity(IUserIdentity type)
        {
            if (type == null)
                throw new ArgumentNullException(nameof(type));

            if (type.Provider == "Google")
            {
                return new GoogleProvider();
            }
            // ... and so on, check on each type of identity

            return new ConveyerProvider();
        }
    }
}
