using Microsoft.AspNetCore.Mvc;
namespace DCOneCrypto.Api.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class DefaultController : ControllerBase
    {
        // GET
        [Route("/")]
        [Route("/docs")]
        [Route("/swagger")]
        public IActionResult Index()
        {
            return new RedirectResult("/api-docs/index.html");
        }
    }
}