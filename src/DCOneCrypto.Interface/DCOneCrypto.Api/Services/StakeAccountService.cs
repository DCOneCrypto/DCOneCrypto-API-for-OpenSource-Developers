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
        public async Task<string> GetAccountUtxos(string _stake_address)
        {
            string newurl = hosturl + "/account_utxos?_stake_address=" + _stake_address;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
    }
}
