using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager(new EFDestinationDAL());
        public IViewComponentResult Invoke() 
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
