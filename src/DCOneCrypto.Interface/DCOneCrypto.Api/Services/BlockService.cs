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
    public class BlockService : CustomBaseService
    {     
        public async Task<string> GetBlocks()
        {           
            string newurl = hosturl + "/blocks";
            var request = new RestRequest (newurl, Method.Get);
            return await Execute(request, newurl);
            
        }
       public async Task<string> GetBlockInfo(BlockHashesModel blockHashes)
       {
           string newurl = hosturl + "/block_info";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(blockHashes);
           return await Execute(request, newurl);

       }
       public async Task<string> GetBlockTxs(BlockHashesModel blockHashes)
       {
           string newurl = hosturl + "/block_txs";
           var request = new RestRequest(newurl, Method.Post);
           request.AddHeader("Content-Type", "application/json");
           request.AddJsonBody(blockHashes);
           return await Execute(request, newurl);

       }
    }
}
