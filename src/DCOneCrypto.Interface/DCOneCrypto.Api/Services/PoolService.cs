using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class PoolService : CustomBaseService
    {     
        public async Task<string> GetPoolList()
        {           
            string newurl = hosturl + "/pool_list";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }

        public async Task<string> GetPoolInfo(object pool_bech32_ids)
        {
           string newurl = hosturl + "/pool_info";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(pool_bech32_ids);
           return await Execute(request, newurl);

        } 
        public async Task<string> GetPoolStakeSnapshot(string _pool_bech32)
        {
            string newurl = hosturl + "/pool_stake_snapshot?_pool_bech32=" + _pool_bech32;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPoolDelegators(string _pool_bech32)
        {
            string newurl = hosturl + "/pool_delegators?_pool_bech32=" + _pool_bech32;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPoolDelegatorsHisory(string _pool_bech32, string _epoch_no)
        {
            string newurl = hosturl + "/pool_delegators_history?_pool_bech32=" + _pool_bech32+ "& _epoch_no="+ _epoch_no;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPoolBlocks(string _pool_bech32, string _epoch_no)
        {
            string newurl = hosturl + "/pool_blocks?_pool_bech32=" + _pool_bech32 + "& _epoch_no=" + _epoch_no;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPoolHistory(string _pool_bech32, string _epoch_no)
        {
            string newurl = hosturl + "/pool_history?_pool_bech32=" + _pool_bech32 + "& _epoch_no=" + _epoch_no;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPoolUpdates(string _pool_bech32)
        {
            string newurl = hosturl + "/pool_updates?_pool_bech32=" + _pool_bech32;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPoolRelays()
        {
            string newurl = hosturl + "/pool_relays";
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }

        public async Task<string> GetPoolMetadata(object pool_bech32_ids)
        {
           string newurl = hosturl + "/pool_metadata";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(pool_bech32_ids);
           return await Execute(request, newurl);

        } 

    }
}
