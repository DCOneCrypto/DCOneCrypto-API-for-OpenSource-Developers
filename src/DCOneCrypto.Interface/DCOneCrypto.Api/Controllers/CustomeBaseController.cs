using DCOneCrypto.Common.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace DCOneCrypto.Api.Controllers
{
    [Route("api/v0")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        //[NonAction]
        //public IActionResult CreateActionResult<T>(CustomResponse<T> response)
        //{
        //    if (response.StatusCode == 204)
        //        return new ObjectResult(null)
        //        {
        //            StatusCode = response.StatusCode
        //        };
        //    return new ObjectResult(response)
        //    {
        //        StatusCode = response.StatusCode
        //    };
        //}

    }
}
