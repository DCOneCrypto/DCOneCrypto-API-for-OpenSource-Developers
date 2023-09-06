using DCOneCrypto.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class AssetController : ControllerBase
    {
        private readonly ILogger<AssetController> _logger;
        private readonly AssetService _assetService;

        public AssetController(
            ILogger<AssetController> logger,
            AssetService assetService)
        {
            _logger = logger;
            _assetService = assetService;
        }

        [Route("asset_list")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetList()
        {
            var res = await _assetService.GetAssetList();
            return Ok(res);
        }

        [Route("asset_token_registry")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetTokenRegistry()
        {
            var res = await _assetService.GetAssetTokenRegistry();
            return Ok(res);
        }

        [Route("asset_addresses")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetAddresses(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864", string _asset_name = "52455655")
        {
            var res = await _assetService.GetAssetAddresses(_asset_policy, _asset_name);
            return Ok(res);
        }

        [Route("asset_nft_address")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetNFTAddress(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864", string _asset_name= "52455655")
        {
            var res = await _assetService.GetAssetNFTAddress(_asset_policy, _asset_name);
            return Ok(res);
        }

        [Route("asset_info")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetInfo(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864", string _asset_name= "52455655")
        {
            var res = await _assetService.GetAssetInfo(_asset_policy, _asset_name);
            return Ok(res);
        }

        [Route("asset_history")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetHistory(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864", string _asset_name= "52455655")
        {
            var res = await _assetService.GetAssetHistory(_asset_policy, _asset_name);
            return Ok(res);
        }

        [Route("policy_asset_addresses")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPolicyAssetAddresses(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864")
        {
            var res = await _assetService.GetPolicyAssetAddresses(_asset_policy);
            return Ok(res);
        }

        [Route("policy_asset_info")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPolicyAssetInfo(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864")
        {
            var res = await _assetService.GetPolicyAssetInfo(_asset_policy);
            return Ok(res);
        }


        [Route("policy_asset_list")]
        [HttpGet]
        public async Task<ActionResult<string>> GetPolicyAssetList(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864")
        {
            var res = await _assetService.GetPolicyAssetList(_asset_policy);
            return Ok(res);
        }

        [Route("asset_summary")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetSumary(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864", string _asset_name = "52455655"    )
        {
            var res = await _assetService.GetAssetSumary(_asset_policy, _asset_name);
            return Ok(res);
        }

        [Route("asset_txs")]
        [HttpGet]
        public async Task<ActionResult<string>> GetAssetTransactions(string _asset_policy= "94cbb4fcbcaa2975779f273b263eb3b5f24a9951e446d6dc4c135864", string _asset_name= "52455655", int _after_block_height= 8547193, bool _history=false)
        {
            var res = await _assetService.GetAssetTransactions(_asset_policy, _asset_name, _after_block_height, _history);
            return Ok(res);
        }

    }
}
