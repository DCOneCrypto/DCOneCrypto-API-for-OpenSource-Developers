using Swashbuckle.AspNetCore.Filters;

namespace DCOneCrypto.Api.Models
{
    public class TxHashesRequestExample : IExamplesProvider<TxHashesModel>
    {
        public TxHashesModel GetExamples()
        {
            return new TxHashesModel()
            {
                _tx_hashes = new List<string>()
                {
                    "12dd71ea42c8b6538d87700429cefa8fd75a4838efd4cbdd1ea3886f1bc9a234",
                    "2a13b9ac7102c25f0398cd501fb7911a1fa649e3537a9dea5985ce8016695b26"
                }
            };
        }
    }

}
