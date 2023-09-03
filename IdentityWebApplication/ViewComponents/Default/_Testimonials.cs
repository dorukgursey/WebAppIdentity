using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.ViewComponents.Default
{
    public class _Testimonials : ViewComponent
    {
        TestimonialsManager testimonialsManager = new TestimonialsManager(new EFTestimonialDAL());
        public IViewComponentResult Invoke() 
        {
            var values = testimonialsManager.TGetList();
            return View(values);
        }
    }
}
