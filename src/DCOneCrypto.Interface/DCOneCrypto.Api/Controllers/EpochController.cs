using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
   
    public class EpochController : CustomBaseController
    {
        private readonly ILogger<EpochController> _logger;
        private readonly EpochService _epochService;

        public EpochController(
            ILogger<EpochController> logger,
            EpochService epochService)
        {
            _logger = logger;
            _epochService = epochService;
        }

        [Route("epoch_info")]
        [HttpGet]
        public async Task<ActionResult<string>> GetEpochInfo(string _epoch_no,bool _include_next_epoch)
        { 
            var res = await _epochService.GetEpochInfo(_epoch_no, _include_next_epoch);
            return Ok(res);
        }
        [Route("epoch_params")]
        [HttpGet]
        public async Task<ActionResult<string>> GetEpochParams(string _epoch_no)
        {
            var res = await _epochService.GetEpochParams(_epoch_no);
            return Ok(res);
        }
        [Route("epoch_block_protocols")]
        [HttpGet]
        public async Task<ActionResult<string>> GetEpochBlockProtocols(string _epoch_no)
        {
            var res = await _epochService.GetEpochBlockProtocols(_epoch_no);
            return Ok(res);
        }

    }
}
