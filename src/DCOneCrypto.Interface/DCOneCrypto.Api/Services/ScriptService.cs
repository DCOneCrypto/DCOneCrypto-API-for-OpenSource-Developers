using RestSharp;


namespace DCOneCrypto.Api.Services
{
    public class ScriptService : CustomBaseService
    {     
        public async Task<string> GetNativeScriptList()
        {           
            string newurl = hosturl + "/native_script_list";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);            
        }
        public async Task<string> GetPlutusScriptList()
        {
            string newurl = hosturl + "/plutus_script_list";
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);
        }
        public async Task<string> GetScriptHash(string _script_hash)
        {
            string newurl = hosturl + "/script_redeemers?_script_hash=" + _script_hash;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);
        }

        public async Task<string> GetDatumInfo(object _datum_hashes)
        {
           string newurl = hosturl + "/datum_info";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(_datum_hashes);
           return await Execute(request, newurl);
        }

    }
}
