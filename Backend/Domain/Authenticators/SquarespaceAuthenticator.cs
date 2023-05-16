using RestSharp;
using RestSharp.Authenticators;
using System.Configuration;

namespace Domain.Authenticators
{
    [Obsolete]
    public class SquarespaceAuthenticator : AuthenticatorBase
    {
        private readonly string _baseUrl;

        public SquarespaceAuthenticator(string baseUrl) : base(baseUrl)
        {
            _baseUrl = baseUrl;
        }

        protected override async ValueTask<Parameter> GetAuthenticationParameter(string accessToken)
        {
            Token = string.IsNullOrEmpty(accessToken) ? await GetToken() : Token;
            return new HeaderParameter(KnownHeaders.Authorization, Token);
        }

        private static Task<string> GetToken()
        {
            return Task.Factory.StartNew(() =>
            {
                return $"Bearer {ConfigurationManager.AppSettings["key"] ?? ""}";
            });
        }
    }
}
