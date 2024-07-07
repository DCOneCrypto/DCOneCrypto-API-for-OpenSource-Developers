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
            return await Execute(request, newurl);

        }
    }
}
