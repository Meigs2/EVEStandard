﻿using EVEStandard.Models.SSO;

namespace EVEStandard.Models.API
{
    public class AuthDTO
    {
        public AccessTokenDetails AccessToken { get; set; }
        public int CharacterID { get; set; }
        public string Scopes { get; set; }
    }
}
