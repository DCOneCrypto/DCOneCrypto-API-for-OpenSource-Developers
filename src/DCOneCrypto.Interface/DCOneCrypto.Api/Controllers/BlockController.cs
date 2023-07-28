using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class BlockController : ControllerBase
    {
        private readonly ILogger<BlockController> _logger;
        private readonly BlockService _blockService;

        public BlockController(
            ILogger<BlockController> logger,
            BlockService blockService)
        {
            _logger = logger;
            _blockService = blockService;
        }

        [Route("blocks")]
        [HttpGet]
        public async Task<ActionResult<string>> GetBlocks()
        {
            var res = await _blockService.GetBlocks();
            return Ok(res);
        }
        //[Route("block_info")]
        //[HttpPost]
        //public async Task<ActionResult<string>> GetBlockInfo([FromBody]string blockHashes)
        //{
        //    var res = await _blockService.GetBlockInfo(blockHashes);
        //    return Ok(res);
        //}

    }
}
