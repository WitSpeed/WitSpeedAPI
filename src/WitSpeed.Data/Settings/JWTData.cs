using System;
using System.Collections.Generic;
using System.Text;

namespace WitSpeed.Data.Settings
{
    public class JWTData
    {
        public const string Data = "JWTConfigurations";
        public TimeSpan TokenLifeTime { get; set; }

        public string SecretKey { get; set; }

        public string Issuer { get; set; }

        public string Audience { get; set; }
    }
}
