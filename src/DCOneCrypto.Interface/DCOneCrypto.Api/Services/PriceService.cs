using RestSharp;
using System.Net;

namespace DCOneCrypto.Api.Services
{
    public class PriceService: CustomBaseService
    {
        public async Task<string> Price(string tokenid)
        {
            string newurl = hosturl + "/swap/averagePrice/ADA/" + tokenid;
            var request = new RestRequest(newurl, Method.Get);
            request.AddHeader("Is-Dev", "true");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
            return await Execute(request, newurl);

        }
    }
}
