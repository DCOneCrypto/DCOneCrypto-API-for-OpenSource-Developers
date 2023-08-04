using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;
using DCOneCrypto.Api.Models;

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
        [ProducesResponseType(typeof(AddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAddressInfo([FromBody] AddressModel model)
        {
            AddressModel addresses = new AddressModel()
            {
                _addresses = model._addresses
            };
            var res = await _addressService.GetAddressInfo(addresses);
           return Ok(res);
        }

        [Route("address_txs")]
        [HttpPost]
        [ProducesResponseType(typeof(AddressTxModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAddressTxs([FromBody] AddressTxModel model)
        {
            AddressTxModel addressesTx = new AddressTxModel()
            {
                _addresses = model._addresses,
                _after_block_height=model._after_block_height
            };
            var res = await _addressService.GetAddressTxs(addressesTx);
           return Ok(res);
        }

        [Route("credential_utxos")]
        [HttpPost]
        [ProducesResponseType(typeof(PaymentCredentialsModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetCredentialUtxos([FromBody]PaymentCredentialsModel model)
        {
            PaymentCredentialsModel paymentCredential = new PaymentCredentialsModel()
            {
                _payment_credentials = model._payment_credentials
            }; 
            var res = await _addressService.GetCredentialUtxos(paymentCredential);
           return Ok(res);
        }

        [Route("address_assets")]
        [HttpPost]
        [ProducesResponseType(typeof(AddressModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAddressAssets([FromBody] AddressModel model)
        {
            AddressModel addresses = new AddressModel()
            {
                _addresses = model._addresses
            };
            var res = await _addressService.GetAddressAssets(addresses);
           return Ok(res);
        }

        [Route("credential_txs")]
        [HttpPost]
        [ProducesResponseType(typeof(PaymentCredentialsTxModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetCredentialTxs([FromBody] PaymentCredentialsTxModel model)
        {
            PaymentCredentialsTxModel paymentCredentialsTx = new PaymentCredentialsTxModel()
            {
                _payment_credentials = model._payment_credentials,
                _after_block_height=model._after_block_height
            };
            var res = await _addressService.GetCredentialTxs(paymentCredentialsTx);
           return Ok(res);
        }

    }
}
