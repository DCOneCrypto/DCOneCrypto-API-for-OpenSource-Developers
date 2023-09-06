using DCOneCrypto.Api.Models;
using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class EpochService : CustomBaseService
    {        
        public async Task<string> GetEpochInfo(string epoch_no,bool include_next_epoch)
        {

            string newurl = hosturl + "/epoch_info?_epoch_no=" + epoch_no.ToString()+ "&_include_next_epoch=" + include_next_epoch.ToString();
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetEpochParams(string epoch_no)
        {

            string newurl = hosturl + "/epoch_params?_epoch_no=" + epoch_no.ToString();
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetEpochBlockProtocols(string epoch_no)
        {

            string newurl = hosturl + "/epoch_block_protocols?_epoch_no=" + epoch_no.ToString();
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }

    }
}
