using System.Collections.Generic;
using Conveyer.Services.Identity.Factories.Interfaces;
using Conveyer.Services.Identity.Interfaces;
using Conveyer.Services.Identity.Models;
using Conveyer.Services.Identity.Providers;

namespace Conveyer.Services.Identity.Factories
{
    public class SystemUserFactory : IUserFactory
    {
        public IUser CreateUser(string arg1, string arg2)
        {
            return new SystemUser(arg1, arg2);
        }

        public IUserIdentity CreateIdentity(string name)
        {
            // NOTE: How do we know what to return from here?
            return new ConveyerProvider();
        }
    }
}
