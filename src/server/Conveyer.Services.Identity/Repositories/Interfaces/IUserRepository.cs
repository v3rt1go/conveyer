namespace Conveyer.Services.Identity.Repositories.Interfaces
{
    using Conveyer.Services.Identity.Factories.Interfaces;
    using Conveyer.Services.Identity.Interfaces;

    public interface IUserRepository
    {
        void RegisterUser(IUserFactory userFactory);

        void UpdateUser(IUser user);

        void SetIdentity(IUserIdentity identity);
    }
}
