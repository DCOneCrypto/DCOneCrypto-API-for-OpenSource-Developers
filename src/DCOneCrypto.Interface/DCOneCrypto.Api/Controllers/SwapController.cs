using DCOneCrypto.Api.Models.HunterDEX.Response;
using DCOneCrypto.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class SwapController : ControllerBase
    {
        private readonly ILogger<SwapController> _logger;
        private readonly PriceService _priceService;

        public SwapController(
            ILogger<SwapController> logger,
            PriceService priceService)
        {
            _logger = logger;
            _priceService = priceService;
        }

        [Route("price")]
        [HttpGet]
        public async Task<ActionResult<string>> Price(string tokenid = "95a427e384527065f2f8946f5e86320d0117839a5e98ea2c0b55fb0048554e54")
        {
            var res = await _priceService.Price(tokenid);
            averagePrice? response = res != null ? JsonConvert.DeserializeObject<averagePrice>(res) : new averagePrice();
            return Ok(response);
        }
    }
}
