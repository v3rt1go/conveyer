namespace Conveyer.Services.Identity.Factories.Interfaces
{
    using Conveyer.Services.Identity.Interfaces;

    public interface IUserFactory
    {
        IUser CreateUser(string arg1, string arg2);

        IUserIdentity CreateIdentity(string name);
    }
}
