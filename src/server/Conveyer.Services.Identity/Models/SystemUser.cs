using System;

namespace Conveyer.Services.Identity.Models
{
    using Conveyer.Services.Identity.Interfaces;

    public class SystemUser : IUser
    {
        public SystemUser(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
                throw new ArgumentException("First name must not be empty.");
            if (string.IsNullOrEmpty(lastName))
                throw new ArgumentException("Last name must not be empty.");
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
