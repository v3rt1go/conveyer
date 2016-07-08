namespace Conveyer.Services.Identity.Repositories
{
    using System;
    using Conveyer.Services.Identity.Factories.Interfaces;
    using Conveyer.Services.Identity.Interfaces;
    using Conveyer.Services.Identity.Repositories.Interfaces;

    public class ApplicationUserRepository : IUserRepository
    {
        public void RegisterUser(IUserFactory userFactory)
        {
            IUser user = userFactory.CreateUser();
        }

        public void UpdateUser(IUser user)
        {
            throw new NotImplementedException();
        }
    }
}
