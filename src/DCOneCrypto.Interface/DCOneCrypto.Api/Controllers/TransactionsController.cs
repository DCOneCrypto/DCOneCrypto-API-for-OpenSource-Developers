using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;
using DCOneCrypto.Api.Models;

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

        [Route("tx_info")]
        [HttpPost]
        [ProducesResponseType(typeof(TxHashesModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetTxInfo([FromBody] TxHashesModel model)
        {
            TxHashesModel txHashes = new TxHashesModel()
            {
                _tx_hashes = model._tx_hashes
            };
            var res = await _transactionsService.GetTxInfo(txHashes);
           return Ok(res);
        }

        [Route("tx_utxos")]
        [HttpPost]
        [ProducesResponseType(typeof(TxHashesModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetTxUtxos([FromBody] TxHashesModel model)
        {
            TxHashesModel txHashes = new TxHashesModel()
            {
                _tx_hashes = model._tx_hashes
            };
            var res = await _transactionsService.GetTxUtxos(txHashes);
           return Ok(res);
        }

        [Route("tx_metadata")]
        [HttpPost]
        [ProducesResponseType(typeof(TxHashesModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetTxMetadata([FromBody] TxHashesModel model)
        {
            TxHashesModel txHashes = new TxHashesModel()
            {
                _tx_hashes = model._tx_hashes
            };
            var res = await _transactionsService.GetTxMetadata(txHashes);
           return Ok(res);
        }
        
        [Route("tx_metalabels")]
        [HttpGet]
        public async Task<ActionResult<string>> GetTxMetalabels()
        {
            var res = await _transactionsService.GetTxMetalabels();
            return Ok(res);
        }

        [Route("tx_status")]
        [HttpPost]
        [ProducesResponseType(typeof(TxHashesModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetTxStatus([FromBody] TxHashesModel model)
        {
            TxHashesModel txHashes = new TxHashesModel()
            {
                _tx_hashes = model._tx_hashes
            };
            var res = await _transactionsService.GetTxStatus(txHashes);
           return Ok(res);
        }
       

    }
}
