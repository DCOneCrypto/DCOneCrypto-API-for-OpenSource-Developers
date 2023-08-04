using Microsoft.AspNetCore.Mvc;
using DCOneCrypto.Api.Services;
using Asp.Versioning;
using DCOneCrypto.Api.Models;

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
        [ProducesResponseType(typeof(DatumHashesModel), 201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetDatumInfo([FromBody] DatumHashesModel model)
        {
            DatumHashesModel datumHashes = new DatumHashesModel()
            {
                _datum_hashes = model._datum_hashes
            }; 
            var res = await _scriptService.GetDatumInfo(datumHashes);
           return Ok(res);
        }

    }
}
