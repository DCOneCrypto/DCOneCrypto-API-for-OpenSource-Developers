using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class StakeAddressEpochNoRequestExample : IExamplesProvider<StakeAddressEpochNoModel>
    {
        public StakeAddressEpochNoModel GetExamples()
        {
            return new StakeAddressEpochNoModel()
            {
                _stake_addresses = new List<string>()
                {
                    "stake1u8rafat8xgerrl8hjeumqy0uu7x6cp3xm8886yt2q5ngpmcdgwlk5",
                    "stake1u9f9v0z5zzlldgx58n8tklphu8mf7h4jvp2j2gddluemnssjfnkzz"
                },
                _epoch_no=400
            };
        }
    }

}
