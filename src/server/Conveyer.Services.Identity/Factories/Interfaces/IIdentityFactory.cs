using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveyer.Services.Identity.Interfaces;

namespace Conveyer.Services.Identity.Factories.Interfaces
{
    public interface IIdentityFactory
    {
        IUserIdentity CreateIdentity(IUserIdentity type);
    }
}
