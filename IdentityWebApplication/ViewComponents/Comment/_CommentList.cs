using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());
        public IViewComponentResult Invoke(int id) 
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
