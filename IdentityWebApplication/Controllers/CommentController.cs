using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace IdentityWebApplication.Controllers
{

    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentDAL());

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.CommentDate = DateTime.UtcNow;
            p.CommentState = true;
            commentManager.TAdd(p);
            return RedirectToAction("Index", "Destination");
        }
    }
}
