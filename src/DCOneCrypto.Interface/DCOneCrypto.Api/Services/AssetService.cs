using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class AssetService : CustomBaseService
    {     
        public async Task<string> GetAssetList()
        {           
            string newurl = hosturl + "/asset_list";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }
        public async Task<string> GetAssetTokenRegistry()
        {
            string newurl = hosturl + "/asset_token_registry";
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetAssetAddresses(string _asset_policy, string _asset_name)
        {
            string newurl = hosturl + "/asset_addresses?_asset_policy="+ _asset_policy + "&_asset_name="+ _asset_name;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        
        public async Task<string> GetAssetNFTAddress(string _asset_policy, string _asset_name)
        {
            string newurl = hosturl + "/asset_nft_address?_asset_policy=" + _asset_policy + "&_asset_name=" + _asset_name;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetAssetInfo(string _asset_policy, string _asset_name)
        {
            string newurl = hosturl + "/asset_info?_asset_policy=" + _asset_policy + "&_asset_name=" + _asset_name;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetAssetHistory(string _asset_policy, string _asset_name)
        {
            string newurl = hosturl + "/asset_history?_asset_policy=" + _asset_policy + "&_asset_name=" + _asset_name;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPolicyAssetAddresses(string _asset_policy)
        {
            string newurl = hosturl + "/policy_asset_addresses?_asset_policy=" + _asset_policy;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPolicyAssetInfo(string _asset_policy)
        {
            string newurl = hosturl + "/policy_asset_info?_asset_policy=" + _asset_policy;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetPolicyAssetList(string _asset_policy)
        {
            string newurl = hosturl + "/policy_asset_list?_asset_policy=" + _asset_policy;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetAssetSumary(string _asset_policy, string _asset_name)
        {
            string newurl = hosturl + "/asset_summary?_asset_policy=" + _asset_policy + "&_asset_name=" + _asset_name;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetAssetTransactions(string _asset_policy, string _asset_name, int _after_block_height, bool _history)
        {
            string newurl = hosturl + "/asset_txs?_asset_policy=" + _asset_policy + "&_asset_name=" + _asset_name+ "&_after_block_height="+ _after_block_height + "&_history="+ _history;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }

    }
}
