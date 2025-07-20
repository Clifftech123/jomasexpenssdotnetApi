

namespace jomasexpenssdotnetApi.Src.Domain.Contracts
{
    public class JwtSettings
    {
        /// <summary>
        /// The secret key used to sign the JWT tokens.
         
        /// </summary>
        public string SecretKey { get; set; } = string.Empty;

        /// <summary>
        /// The issuer of the JWT tokens.
        /// 
        /// </summary>
        public string Issuer { get; set; } = string.Empty;

        /// <summary>
        /// The audience for which the JWT tokens are intended.
        /// This is typically the application or service that will consume the tokens.
        /// </summary>
        public string Audience { get; set; } = string.Empty;

        /// <summary>
        /// The expiration time for the JWT tokens in minutes.
        /// </summary>
        public int ExpirationMinutes { get; set; }
        
    }
}