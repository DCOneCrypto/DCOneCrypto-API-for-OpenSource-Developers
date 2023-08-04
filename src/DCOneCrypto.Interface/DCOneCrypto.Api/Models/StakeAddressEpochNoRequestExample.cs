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
                    "stake1u9p50xsyfms84f780uk59e9989mmmwxtc7m8rek8sy5wl3qlnndkl",
                    "stake1u80v4reejazh877vk8pdxj0mynm5rlnmfhqedyls6g58e7sfcs33n"
                },
                _epoch_no=400
            };
        }
    }

}
