using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;
        private readonly AddressService _addressService;

        public AddressController(
            ILogger<AddressController> logger,
            AddressService addressService)
        {
            _logger = logger;
            _addressService = addressService;
        }

        [Route("address_info")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAddressInfo([FromBody]object addresses)
        {
           var res = await _addressService.GetAddressInfo(addresses);
           return Ok(res);
        }

        [Route("address_txs")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAddressTxs([FromBody]object addresses)
        {
           var res = await _addressService.GetAddressTxs(addresses);
           return Ok(res);
        }

        [Route("credential_utxos")]
        [HttpPost]
        public async Task<ActionResult<string>> GetCredentialUtxos([FromBody]object addresses)
        {
           var res = await _addressService.GetCredentialUtxos(addresses);
           return Ok(res);
        }

        [Route("address_assets")]
        [HttpPost]
        public async Task<ActionResult<string>> GetAddressAssets([FromBody]object addresses)
        {
           var res = await _addressService.GetAddressAssets(addresses);
           return Ok(res);
        }

        [Route("credential_txs")]
        [HttpPost]
        public async Task<ActionResult<string>> GetCredentialTxs([FromBody]object addresses)
        {
           var res = await _addressService.GetCredentialTxs(addresses);
           return Ok(res);
        }

    }
}
