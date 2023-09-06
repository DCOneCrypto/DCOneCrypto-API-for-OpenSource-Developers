using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class AddressRequestExample : IExamplesProvider<AddressModel>
    {
        public AddressModel GetExamples()
        {
            return new AddressModel()
            {
                _addresses = new List<string>()
                {
                    "addr1qy5jnw94vfa0t9n6mss4uefwxk66pqv3043q3lhu9t3l8f43cl8xl27d727zrgywqx73ruq5ceh6f2jtzst5twzehejs0hyumc",
                    "addr1qyvdh8kv0d38l3vf34v3jw5ds6fr9qtvrrc6n3m5e8nte9g5hs4c0ldc2kwknjhjp4pg5y4eskwaeuse7au8pjxqzcsqnxuumm"
                }
            };
        }
    }

}
