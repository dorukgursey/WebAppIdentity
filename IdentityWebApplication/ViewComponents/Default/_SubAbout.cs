using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.ViewComponents.Default
{
    public class _SubAbout: ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EFSubAboutDAL());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetList();
            return View(values);
        }
    }
}
