using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ILogger<TransactionsController> _logger;
        private readonly TransactionsService _transactionsService;

        public TransactionsController(
            ILogger<TransactionsController> logger,
            TransactionsService transactionsService)
        {
            _logger = logger;
            _transactionsService = transactionsService;
        }

        [Route("tx_metalabels")]
        [HttpGet]
        public async Task<ActionResult<string>> GetTxMetalabels()
        {
            var res = await _transactionsService.GetTxMetalabels();
            return Ok(res);
        }
       

    }
}
