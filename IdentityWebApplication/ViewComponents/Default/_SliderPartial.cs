using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();
        }
    }
}
