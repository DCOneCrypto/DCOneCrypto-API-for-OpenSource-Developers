using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class BlockHashesRequestExample : IExamplesProvider<BlockHashesModel>
    {
        public BlockHashesModel GetExamples()
        {
            return new BlockHashesModel()
            {
                _block_hashes = new List<string>()
                {
                    "ddabe442fa6377908b4d71462079d72abed9a974f1aa7b93efaf26a63d538728",
                    "75de6dfa1a11e99f67cad0ab92b5274255de3d450fca6e0cc7157634e7c3760d",
                    "51edc3360a9895cfeacf4b0051aa08a3b08e7aa6a9b966c408cc5fa63a515671"
                }
            };
        }
    }

}
