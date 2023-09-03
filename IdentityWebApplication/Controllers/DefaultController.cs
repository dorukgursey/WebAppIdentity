using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
