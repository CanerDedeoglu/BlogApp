using BlogAPP.Data.Abstract;
using BlogAPP.Entity.Concrete.EfCore;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPP.Entity.Controllers
{
    public class PostController: Controller
    {
        private IPostRepository _context;

        public PostController(IPostRepository context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Posts.ToList());
        }
        
    }
}