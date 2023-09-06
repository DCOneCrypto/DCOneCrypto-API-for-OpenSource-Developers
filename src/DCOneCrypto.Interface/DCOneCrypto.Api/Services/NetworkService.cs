using RestSharp;

namespace DCOneCrypto.Api.Services
{
    public class NetworkService : CustomBaseService
    {     
        public async Task<string> GetTip()
        {
           
            string newurl = hosturl + "/tip";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }
        public async Task<string> GetGenesis()
        {

            string newurl = hosturl + "/genesis";
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetTotals(string epoch_no)
        {

            string newurl = hosturl + "/totals?_epoch_no=" + epoch_no;
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
        public async Task<string> GetParam_Updates()
        {

            string newurl = hosturl + "/param_updates";
            var request = new RestRequest(newurl, Method.Get);
            return await Execute(request, newurl);

        }
    }
}
