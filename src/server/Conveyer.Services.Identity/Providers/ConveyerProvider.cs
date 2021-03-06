﻿using System;
using Conveyer.Services.Identity.Interfaces;

namespace Conveyer.Services.Identity.Providers
{
    public class ConveyerProvider : IUserIdentity
    {
        public string Provider { get; set; }
        public string Token { get; set; }
        public DateTime IssuedOn { get; set; }
    }
}
