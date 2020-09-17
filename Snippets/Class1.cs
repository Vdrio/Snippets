using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;



namespace Snippets
{
    public class Class1
    {


        public const string defaultUri = "https://localhost:5001/";
        public static CookieContainer Cookies = new CookieContainer();
        HttpClient GetClient()
        {
            HttpClient _client;
            _client = new HttpClient(new HttpClientHandler() { CookieContainer = Cookies })
            {
                BaseAddress = new Uri(defaultUri),
            };
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.Timeout = TimeSpan.FromMilliseconds(10000);

            return _client;
        }


    }
}
