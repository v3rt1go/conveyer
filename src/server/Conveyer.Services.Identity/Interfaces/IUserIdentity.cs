using System;

namespace Conveyer.Services.Identity.Interfaces
{
    public interface IUserIdentity
    {
        string Provider { get; set; }

        string Token { get; set; }

        DateTime IssuedOn { get; set; }
    }
}
