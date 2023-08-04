using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class PoolBech32IdsRequestExample : IExamplesProvider<PoolBech32IdsModel>
    {
        public PoolBech32IdsModel GetExamples()
        {
            return new PoolBech32IdsModel()
            {
                _pool_bech32_ids = new List<string>()
                {
                    "addr1qxdt2hntsw9x6m9trh73yuh40yxpv5wcf9vq3yu29rrzq5hrzr27g03klu862usxqsru794d03gzkk8n86ta34n85z0spd54q2",
                    "addr1qygvqerg6m3m20e9gutvptd62rley6z590854rapetu30nh968rppz2j6ykwr0lruexm6ydlhc3gl7mjr7j2ze2dq2aqvypdwr"
                }
            };
        }
    }

}
