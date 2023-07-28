using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class ScriptController : ControllerBase
    {
        private readonly ILogger<ScriptController> _logger;
        private readonly ScriptService _scriptService;

        public ScriptController(
            ILogger<ScriptController> logger,
            ScriptService scriptService)
        {
            _logger = logger;
            _scriptService = scriptService;
        }

        [Route("native_script_list")]
        [HttpGet]
        public async Task<ActionResult<string>> GetNativeScriptList()
        {
            var res = await _scriptService.GetNativeScriptList();
            return Ok(res);
        }

        [Route("plutus_script_list")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPlutusScriptList()
        {
            var res = await _scriptService.GetPlutusScriptList();
            return Ok(res);
        }

        [Route("script_redeemers")]
        [HttpGet]
        public async Task<ActionResult<string>> GetScriptHash(string script_hash)
        {
            var res = await _scriptService.GetScriptHash(script_hash);
            return Ok(res);
        }

        [Route("datum_info")]
        [HttpPost]
        public async Task<ActionResult<string>> GetDatumInfo([FromBody]object datum_hashes)
        {
           var res = await _scriptService.GetDatumInfo(datum_hashes);
           return Ok(res);
        }

    }
}
