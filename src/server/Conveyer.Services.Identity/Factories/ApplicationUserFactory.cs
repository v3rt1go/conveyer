using System;
using System.Collections.Generic;
using Conveyer.Services.Identity.Factories.Interfaces;
using Conveyer.Services.Identity.Interfaces;
using Conveyer.Services.Identity.Models;
using Conveyer.Services.Identity.Providers;

namespace Conveyer.Services.Identity.Factories
{
    public class ApplicationUserFactory : IUserFactory
    {
        public ApplicationUserFactory(Dictionary<string, IUserIdentity> nameToIdentity)
        {
            if (nameToIdentity == null)
                throw new ArgumentNullException(nameof(nameToIdentity));

            this.NameToIdentity = nameToIdentity;
        }

        private Dictionary<string, IUserIdentity> NameToIdentity { get; }

        private IUserIdentity GetIdentity(string name)
        {
            IUserIdentity identity;

            if (!this.NameToIdentity.TryGetValue(name, out identity))
                throw new ArgumentException("Identity provider not found.");

            return identity;
        }

        public IUser CreateUser(string arg1, string arg2)
        {
            // We don't need to do any validation on the strings here
            // specific model validation is handled by the ctor of each
            // concrete implementation

            return new ApplicationUser(arg1, arg2);
        }

        public IUserIdentity CreateIdentity(string name)
        {
            // NOTE: How do we know what identity to return from here?
            // Maybe the identity provider should be FacebookProvider
            //return new GoogleProvider();

            IUserIdentity identityType = this.GetIdentity(name);
            var identityFactory = new IdentityFactory();

            return identityFactory.CreateIdentity(identityType);
        }
    }
}
