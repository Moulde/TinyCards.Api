using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;

namespace TinyCards.Api.Service
{
    public class TinyCardsService
    {
        private string BaseUrl = "https://tinycards.duolingo.com/api/1/";
        public bool Authenticated => _userId > 0;
        private int _userId = -1;

        private readonly IFlurlClient _client;

        public TinyCardsService()
        {
            _client = new FlurlClient(BaseUrl);
            _client.EnableCookies();
        }

        public async Task<User> Login(string username, string password)
        {
            string url = BaseUrl + "login";

            var body = new
            {
                error = "",
                facebookError = "",
                hasResetPassword = "",
                identifier = username,
                isResettingPassword = "",
                password = password
            };

            var loginResponse = await url
                .WithClient(_client)
                .PostJsonAsync(body)
                .ReceiveJson<User>();

            _userId = loginResponse.Id;
            return loginResponse;
        }
    }
}
