using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class TransactionsService : CustomBaseService
    {     
        public async Task<string> GetTxMetalabels()
        {           
            string newurl = hosturl + "/tx_metalabels";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }
        
    }
}
