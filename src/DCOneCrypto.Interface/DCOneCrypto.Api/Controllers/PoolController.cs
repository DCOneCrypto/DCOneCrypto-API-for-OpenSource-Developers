using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class PoolController : ControllerBase
    {
        private readonly ILogger<PoolController> _logger;
        private readonly PoolService _poolService;

        public PoolController(
            ILogger<PoolController> logger,
            PoolService poolService)
        {
            _logger = logger;
            _poolService = poolService;
        }

        [Route("pool_list")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolList()
        {
            var res = await _poolService.GetPoolList();
            return Ok(res);
        }

        [Route("pool_info")]
        [HttpPost]
        public async Task<ActionResult<string>> GetPoolInfo([FromBody]object pool_bech32_ids)
        {
           var res = await _poolService.GetPoolInfo(pool_bech32_ids);
           return Ok(res);
        }

        [Route("pool_stake_snapshot")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolStakeSnapshot(string _pool_bech32)
        {
            var res = await _poolService.GetPoolStakeSnapshot(_pool_bech32);
            return Ok(res);
        }

        [Route("pool_delegators")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolDelegators(string _pool_bech32)
        {
            var res = await _poolService.GetPoolDelegators(_pool_bech32);
            return Ok(res);
        }

        [Route("pool_delegators_history")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolDelegatorsHisory(string _pool_bech32, string _epoch_no)
        {
            var res = await _poolService.GetPoolDelegatorsHisory(_pool_bech32, _epoch_no);
            return Ok(res);
        }

        [Route("pool_blocks")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolBlocks(string _pool_bech32, string _epoch_no)
        {
            var res = await _poolService.GetPoolBlocks(_pool_bech32, _epoch_no);
            return Ok(res);
        }

        [Route("pool_history")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolHistory(string _pool_bech32, string _epoch_no)
        {
            var res = await _poolService.GetPoolHistory(_pool_bech32, _epoch_no);
            return Ok(res);
        }

        [Route("pool_updates")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolUpdates(string _pool_bech32)
        {
            var res = await _poolService.GetPoolUpdates(_pool_bech32);
            return Ok(res);
        }

        [Route("pool_relays")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolRelays()
        {
            var res = await _poolService.GetPoolRelays();
            return Ok(res);
        }

        [Route("pool_metadata")]
        [HttpPost]
        public async Task<ActionResult<string>> GetPoolMetadata([FromBody]object pool_bech32_ids)
        {
           var res = await _poolService.GetPoolMetadata(pool_bech32_ids);
           return Ok(res);
        }

    }
}
