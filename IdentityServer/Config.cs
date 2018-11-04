using IdentityServer4.Models;
using System.Collections.Generic;


namespace IdentityServer
{
    public class Config
    {

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "My API")
            };
        }

        public static IEnumerable<Client> GetClients() => new List<Client>
        {
            // server to server
            // http://docs.identityserver.io/en/release/quickstarts/6_aspnet_identity.html
            // https://github.com/IdentityServer/IdentityServer4.Demo/blob/master/src/IdentityServer4Demo/Config.cs
            new Client
            {
                ClientId = "client",
                ClientSecrets = { new Secret("secret".Sha256()) },

                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = { "api1" },
            }
        };
    }
}
