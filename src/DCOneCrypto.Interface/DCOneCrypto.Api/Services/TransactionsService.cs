using DCOneCrypto.Api.Models;
using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class TransactionsService : CustomBaseService
    {     
        public async Task<string> GetTxInfo(TxHashesModel txHashes)
        {
           string newurl = hosturl + "/tx_info";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(txHashes);
           return await Execute(request, newurl);

        }

        public async Task<string> GetTxUtxos(TxHashesModel txHashes)
        {
           string newurl = hosturl + "/tx_utxos";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(txHashes);
           return await Execute(request, newurl);

        }

        public async Task<string> GetTxMetadata(TxHashesModel txHashes)
        {
           string newurl = hosturl + "/tx_metadata";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(txHashes);
           return await Execute(request, newurl);

        }

        
        public async Task<string> GetTxMetalabels()
        {           
            string newurl = hosturl + "/tx_metalabels";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }

        public async Task<string> GetTxStatus(TxHashesModel txHashes)
        {
           string newurl = hosturl + "/tx_status";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(txHashes);
           return await Execute(request, newurl);

        }
        
        
    }
}
