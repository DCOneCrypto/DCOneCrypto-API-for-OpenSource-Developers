using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class PaymentCredentialsTxRequestExample : IExamplesProvider<PaymentCredentialsTxModel>
    {
        public PaymentCredentialsTxModel GetExamples()
        {
            return new PaymentCredentialsTxModel()
            {
                _payment_credentials = new List<string>()
                {
                   "025b0a8f85cb8a46e1dda3fae5d22f07e2d56abb4019a2129c5d6c52",
                   "13f6870c5e4f3b242463e4dc1f2f56b02a032d3797d933816f15e555"
                },
                _after_block_height= 6238675
            };
        }
    }

}
