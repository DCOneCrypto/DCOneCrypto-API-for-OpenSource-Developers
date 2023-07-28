using System.Text.Json;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class CustomBaseService
    {
        public string hosturl = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["HostUrl"];
        protected async Task<string> Execute(RestRequest request,string urlBase = null)
        {
            RestClient client = new RestClient(urlBase);
            RestResponse response = await client.ExecuteAsync(request);          
            return response.Content;
        }
        protected Task<string> ExecutePost(RestRequest request, string urlBase = null)
        {
            RestClient client = new RestClient(urlBase);
            RestResponse response = client.ExecutePost(request);
            return Task.FromResult<string>(response.Content);
        }
    }
}
