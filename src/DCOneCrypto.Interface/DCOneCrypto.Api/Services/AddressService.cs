using Microsoft.Extensions.Options;
using DCOneCrypto.Api.Models;
using DCOneCrypto.Api.Services;
using DCOneCrypto.Common.Models.Response;
using Microsoft.EntityFrameworkCore;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using static System.Net.Mime.MediaTypeNames;

namespace DCOneCrypto.Api.Services
{
    public class AddressService : CustomBaseService
    {     
        public async Task<string> GetAddressInfo(object addresses)
        {
           string newurl = hosturl + "/address_info";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(addresses);
           return await Execute(request, newurl);

        } 
        public async Task<string> GetAddressTxs(object addresses)
        {
           string newurl = hosturl + "/address_txs";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(addresses);
           return await Execute(request, newurl);

        }  

        public async Task<string> GetCredentialUtxos(object addresses)
        {
           string newurl = hosturl + "/credential_utxos";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(addresses);
           return await Execute(request, newurl);

        } 

        public async Task<string> GetAddressAssets(object addresses)
        {
           string newurl = hosturl + "/address_assets";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(addresses);
           return await Execute(request, newurl);

        }  

        public async Task<string> GetCredentialTxs(object addresses)
        {
           string newurl = hosturl + "/credential_txs";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(addresses);
           return await Execute(request, newurl);

        }      
    }
    
}
