﻿namespace Boiler.Auth.Helpers
{
    public class AuthSettings
    {
        public int RefreshTokenTTL       { get; set; }
        public int AccessTokenTTL        { get; set; }
        public bool RequiresVerification { get; set; }
    }
}
