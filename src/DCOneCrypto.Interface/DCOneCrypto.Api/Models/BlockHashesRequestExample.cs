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
                    "3567e0979b67403646b7b3012d0b6fab92d96bd153fea2ab1bec9e627a330e0c",
                    "321e9f344c02ebdb6ef2a16f4ae1959a6886cc27e7a0b805368b8b6cde90602f",
                    "962e3186901df1baad2261e2dcbd8861540f90e54ad2dbe49888db623383d343"
                }
            };
        }
    }

}
