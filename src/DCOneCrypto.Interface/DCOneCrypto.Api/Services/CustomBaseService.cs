using RestSharp;
using System.Net;

namespace DCOneCrypto.Api.Services
{
    public class CustomBaseService
    {
        public string hosturl = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["HostUrl"];
        protected async Task<string> Execute(RestRequest request, string urlBase = null)
        {
            RestClient client = new RestClient(urlBase);
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            RestResponse response = await client.ExecuteAsync(request);
            return response.Content;
        }

    }
}
