using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;
using DCOneCrypto.Api.Models;

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
        [ProducesResponseType(typeof(PoolBech32IdsModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetPoolInfo([FromBody] PoolBech32IdsModel model)
        {

            PoolBech32IdsModel poolBech32Ids = new PoolBech32IdsModel()
            {
                _pool_bech32_ids = model._pool_bech32_ids
            }; 
            var res = await _poolService.GetPoolInfo(poolBech32Ids);
           return Ok(res);
        }

        [Route("pool_stake_snapshot")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolStakeSnapshot(string _pool_bech32="pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk")
        {
            var res = await _poolService.GetPoolStakeSnapshot(_pool_bech32);
            return Ok(res);
        }

        [Route("pool_delegators")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolDelegators(string _pool_bech32="pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk")
        {
            var res = await _poolService.GetPoolDelegators(_pool_bech32);
            return Ok(res);
        }

        [Route("pool_delegators_history")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolDelegatorsHisory(string _pool_bech32="pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk", string _epoch_no="431")
        {
            var res = await _poolService.GetPoolDelegatorsHisory(_pool_bech32, _epoch_no);
            return Ok(res);
        }

        [Route("pool_blocks")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolBlocks(string _pool_bech32="pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk", string _epoch_no="431")
        {
            var res = await _poolService.GetPoolBlocks(_pool_bech32, _epoch_no);
            return Ok(res);
        }

        [Route("pool_history")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolHistory(string _pool_bech32="pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk", string _epoch_no="431")
        {
            var res = await _poolService.GetPoolHistory(_pool_bech32, _epoch_no);
            return Ok(res);
        }

        [Route("pool_updates")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPoolUpdates(string _pool_bech32="pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk")
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
        [ProducesResponseType(typeof(PoolBech32IdsModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetPoolMetadata([FromBody]PoolBech32IdsModel model)
        {
            PoolBech32IdsModel poolBech32Ids = new PoolBech32IdsModel()
            {
                _pool_bech32_ids = model._pool_bech32_ids
            };
            var res = await _poolService.GetPoolMetadata(model);
           return Ok(res);
        }

    }
}
