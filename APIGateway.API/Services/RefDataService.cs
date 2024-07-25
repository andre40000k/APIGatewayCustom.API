using APIGateway.API.Application.Entyte;
using APIGateway.API.Application.Interfaces;
using APIGateway.API.Common;
using Newtonsoft.Json;

namespace APIGateway.API.Services
{
    public class RefDataService : HttpClientBase, IRefDataService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public RefDataService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = configuration;
        }

        public async Task<string> GetDataAsync(string data)
        {
            var endpoint = _configuration.GetSection("GetByIdShop:link").Value;
            var body = JsonConvert.SerializeObject(data);
            return (await Get<string>(_httpClient, new Uri(endpoint), body)).Value;
        }

        public async Task<string> PostData(JsonObjects jsonObjects)
        {
            ///// Stoped here

            var endpoint = _configuration.GetSection("CreateShop:link").Value;
            string body = "{\"ShopName\":\""+"asdfgh"+"\",\"ShopDescription\":\"22222222222222\"}";
            ////var body = JsonConvert.SerializeObject(data);
            return (await Post<string>(_httpClient, new Uri(endpoint),/* body*/ jsonObjects.JesonMainBadyRequest)).Value;
        }
    }
}
