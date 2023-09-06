using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class StakeAddressRequestExample : IExamplesProvider<StakeAddressModel>
    {
        public StakeAddressModel GetExamples()
        {
            return new StakeAddressModel()
            {
                _stake_addresses = new List<string>()
                {
                    "stake1uy42yjrfu20mjk6vgy8g20ytlnlz83fargdr9c5d7kc2uec3h43xu",
                    "stake1u8wzju2t60eulw9mved8uls9xvfxu0aluryqhqxlzn7e8ps5cwgq2"
                }
            };
        }
    }

}
