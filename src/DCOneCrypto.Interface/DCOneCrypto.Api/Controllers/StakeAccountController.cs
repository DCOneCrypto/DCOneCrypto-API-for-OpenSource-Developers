using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;
using DCOneCrypto.Api.Models;
using DCOneCrypto.Common.Models.CardanoDbSync;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class StakeAccountController : ControllerBase
    {
        private readonly ILogger<StakeAccountController> _logger;
        private readonly StakeAccountService _stakeAccountServicee;

        public StakeAccountController(
            ILogger<StakeAccountController> logger,
            StakeAccountService stakeAccountService)
        {
            _logger = logger;
            _stakeAccountServicee = stakeAccountService;
        }

        [Route("account_list")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAccountList()
        {
            var res = await _stakeAccountServicee.GetAccountList();
            return Ok(res);
        }

        [Route("account_info")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountInfo([FromBody] StakeAddressModel model)
        {
            StakeAddressModel stakeAddress = new StakeAddressModel()
            {
                _stake_addresses = model._stake_addresses
            };
            var res = await _stakeAccountServicee.GetAccountInfo(stakeAddress);
           return Ok(res);
        }

        [Route("account_utxos")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAccountUtxos(string _stake_address)
        {
            var res = await _stakeAccountServicee.GetAccountUtxos(_stake_address);
            return Ok(res);
        }

        [Route("account_info_cached")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountInfoCached([FromBody] StakeAddressModel model)
        {
            StakeAddressModel stakeAddress = new StakeAddressModel()
            {
                _stake_addresses = model._stake_addresses
            }; 
            var res = await _stakeAccountServicee.GetAccountInfoCached(stakeAddress);
           return Ok(res);
        }

        [Route("account_rewards")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressEpochNoModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountRewards([FromBody] StakeAddressEpochNoModel model)
        {
            StakeAddressEpochNoModel stakeAddressEpochNo = new StakeAddressEpochNoModel()
            {
                _stake_addresses = model._stake_addresses,
                _epoch_no=model._epoch_no
            }; 
            var res = await _stakeAccountServicee.GetAccountRewards(stakeAddressEpochNo);
           return Ok(res);
        }

        [Route("account_updates")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountUpdates([FromBody] StakeAddressModel model)
        {
            StakeAddressModel stakeAddress = new StakeAddressModel()
            {
                _stake_addresses = model._stake_addresses
            }; 
            var res = await _stakeAccountServicee.GetAccountUpdates(stakeAddress);
           return Ok(res);
        }

        [Route("account_addresses")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountAddresses([FromBody] StakeAddressModel model)
        {
            StakeAddressModel stakeAddress = new StakeAddressModel()
            {
                _stake_addresses = model._stake_addresses
            }; 
            var res = await _stakeAccountServicee.GetAccountAddresses(stakeAddress);
           return Ok(res);
        }

        [Route("account_assets")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountAssets([FromBody] StakeAddressModel model)
        {
            StakeAddressModel stakeAddress = new StakeAddressModel()
            {
                _stake_addresses = model._stake_addresses
            }; 
            var res = await _stakeAccountServicee.GetAccountAssets(stakeAddress);
           return Ok(res);
        }

        [Route("account_history")]
        [HttpPost]
        [ProducesResponseType(typeof(StakeAddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAccountHistory([FromBody] StakeAddressEpochNoModel model)
        {
            StakeAddressEpochNoModel stakeAddressEpochNo = new StakeAddressEpochNoModel()
            {
                _stake_addresses = model._stake_addresses,
                _epoch_no=model._epoch_no
            };
            var res = await _stakeAccountServicee.GetAccountHistory(stakeAddressEpochNo);
           return Ok(res);
        }


    }
}
