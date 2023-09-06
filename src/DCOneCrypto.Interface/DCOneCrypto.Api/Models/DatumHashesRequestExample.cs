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
                    "18ca176230064f97656ca45eae1533ce06986b87fdedd103b6e8682c380d990a",
                    "28b20e91bbedd2442f558da792fad92340821555e9ff81ed1f33d7da4349c238"
                }
            };
        }
    }

}
