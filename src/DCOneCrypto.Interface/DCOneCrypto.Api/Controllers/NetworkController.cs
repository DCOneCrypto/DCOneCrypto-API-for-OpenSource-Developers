using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
   
    public class NetworkController : CustomBaseController
    {
        private readonly ILogger<NetworkController> _logger;
        private readonly NetworkService _networkService;

        public NetworkController(
            ILogger<NetworkController> logger,
            NetworkService networkService)
        {
            _logger = logger;
            _networkService = networkService;
        }

        [Route("tip")]
        [HttpGet]
        public async Task<ActionResult<string>> GetTip()
        {
            var res = await _networkService.GetTip();
            return Ok(res);
        }
        [Route("genesis")]
        [HttpGet]
        public async Task<ActionResult<string>> GetGenesis()
        {
            var res = await _networkService.GetGenesis();
            return Ok(res);
        }
        [Route("totals")]
        [HttpGet]
        public async Task<ActionResult<string>> GetTotals(string _epoch_no="400")
        {
            var res = await _networkService.GetTotals(_epoch_no);
            return Ok(res);
        }
        [Route("param_updates")]
        [HttpGet]
        public async Task<ActionResult<string>> GetParam_Updates()
        {
            var res = await _networkService.GetParam_Updates();
            return Ok(res);
        }
    }
}
