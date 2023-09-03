using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.ViewComponents.Default
{
    public class _FeatureMain:ViewComponent
    {
        FeatureMainManager featureMainManager = new FeatureMainManager(new EFFeatureMainDAL());
        public IViewComponentResult Invoke() 
        {
            //var values = featureMainManager.TGetList();
            return View();
        }
    }
}
