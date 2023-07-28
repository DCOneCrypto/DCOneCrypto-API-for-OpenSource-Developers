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


        [Route("account_utxos")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAccountUtxos(string _stake_address)
        {
            var res = await _stakeAccountServicee.GetAccountUtxos(_stake_address);
            return Ok(res);
        }


    }
}
