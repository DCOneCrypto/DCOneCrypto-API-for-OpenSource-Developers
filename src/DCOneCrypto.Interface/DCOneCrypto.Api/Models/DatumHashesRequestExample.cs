using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class DatumHashesRequestExample : IExamplesProvider<DatumHashesModel>
    {
        public DatumHashesModel GetExamples()
        {
            return new DatumHashesModel()
            {
                _datum_hashes = new List<string>()
                {
                    "818ee3db3bbbd04f9f2ce21778cac3ac605802a4fcb00c8b3a58ee2dafc17d46",
                    "45b0cfc220ceec5b7c1c62c4d4193d38e4eba48e8815729ce75f9c0ab0e4c1c0"
                }
            };
        }
    }

}
