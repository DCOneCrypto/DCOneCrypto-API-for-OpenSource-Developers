using Microsoft.AspNetCore.Mvc;
namespace DCOneCrypto.Api.Controllers
{
    public class HomeController : ControllerBase
    {
        // GET
        public IActionResult Index()
        {
            return Redirect("/api-docs/index.html");
        }
    }
}