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
                new ApiResource("valuesApi", "My API")
            };
        }

        public static IEnumerable<Client> GetClients() => new List<Client>
        {
            // server to server

            new Client
            {
                ClientId = "client",
                ClientSecrets = { new Secret("secret".Sha256()) },

                AllowedGrantTypes = GrantTypes.ClientCredentials,
                AllowedScopes = { "valuesApi" },
            }
        };
    }
}
