using Newtonsoft.Json;

namespace DCOneCrypto.Api.Models.HunterDEX.Response
{
    public class averagePrice
    {
        [JsonProperty("price_ba")]
        public decimal price { get; set; }
    }
}
