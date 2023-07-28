using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

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
        public async Task<ActionResult<string>> GetAccountInfo([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountInfo(_stake_addresses);
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
        public async Task<ActionResult<string>> GetAccountInfoCached([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountInfoCached(_stake_addresses);
           return Ok(res);
        }

        [Route("account_rewards")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAccountRewards([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountRewards(_stake_addresses);
           return Ok(res);
        }

        [Route("account_updates")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAccountUpdates([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountUpdates(_stake_addresses);
           return Ok(res);
        }

        [Route("account_addresses")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAccountAddresses([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountAddresses(_stake_addresses);
           return Ok(res);
        }

        [Route("account_assets")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAccountAssets([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountAssets(_stake_addresses);
           return Ok(res);
        }

        [Route("account_history")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAccountHistory([FromBody]object _stake_addresses)
        {
           var res = await _stakeAccountServicee.GetAccountHistory(_stake_addresses);
           return Ok(res);
        }


    }
}
