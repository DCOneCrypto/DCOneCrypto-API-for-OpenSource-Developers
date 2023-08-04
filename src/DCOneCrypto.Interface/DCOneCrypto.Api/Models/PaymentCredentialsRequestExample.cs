using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class PaymentCredentialsRequestExample : IExamplesProvider<PaymentCredentialsModel>
    {
        public PaymentCredentialsModel GetExamples()
        {
            return new PaymentCredentialsModel()
            {
                _payment_credentials = new List<string>()
                {
                   "025b0a8f85cb8a46e1dda3fae5d22f07e2d56abb4019a2129c5d6c52",
                   "13f6870c5e4f3b242463e4dc1f2f56b02a032d3797d933816f15e555"
                }
            };
        }
    }

}
