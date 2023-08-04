using DCOneCrypto.Api.Models;
using DCOneCrypto.Common.Models.CardanoDbSync;
using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class StakeAccountService : CustomBaseService
    {     
        public async Task<string> GetAccountList()
        {           
            string newurl = hosturl + "/account_list";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }

        public async Task<string> GetAccountInfo(StakeAddressModel model)
        {
           string newurl = hosturl + "/account_info";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(model);
           return await Execute(request, newurl);
        }
        
        public async Task<string> GetAccountUtxos(string _stake_address)
        {
            string newurl = hosturl + "/account_utxos?_stake_address=" + _stake_address;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }

        public async Task<string> GetAccountInfoCached(object _stake_addresses)
        {
           string newurl = hosturl + "/account_info_cached";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(_stake_addresses);
           return await Execute(request, newurl);
        }

        public async Task<string> GetAccountRewards(StakeAddressEpochNoModel model)
        {
           string newurl = hosturl + "/account_rewards";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(model);
           return await Execute(request, newurl);
        }

        public async Task<string> GetAccountUpdates(StakeAddressModel model)
        {
           string newurl = hosturl + "/account_updates";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(model);
           return await Execute(request, newurl);
        }

        public async Task<string> GetAccountAddresses(StakeAddressModel model)
        {
           string newurl = hosturl + "/account_addresses";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(model);
           return await Execute(request, newurl);
        }

        public async Task<string> GetAccountAssets(StakeAddressModel model)
        {
           string newurl = hosturl + "/account_assets";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(model);
           return await Execute(request, newurl);
        }

        public async Task<string> GetAccountHistory(StakeAddressEpochNoModel model)
        {
           string newurl = hosturl + "/account_history";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(model);
           return await Execute(request, newurl);
        }
    }
}
