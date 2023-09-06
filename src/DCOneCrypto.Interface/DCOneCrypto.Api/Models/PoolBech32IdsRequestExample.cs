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
                    "pool1ases3nklh6gyjf74r7dqm89exjfd520z9cefqru959wcccmrdlk",
                    "pool1z5uqdk7dzdxaae5633fqfcu2eqzy3a3rgtuvy087fdld7yws0xt"
                }
            };
        }
    }

}
