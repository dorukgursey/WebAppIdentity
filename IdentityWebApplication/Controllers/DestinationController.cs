using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        public IActionResult Index()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.Id = id;
            var values = destinationManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }
    }
}
