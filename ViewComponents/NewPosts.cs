
using BlogAPP.Data.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlogAPP.ViewComponents
{

    public class NewPosts : ViewComponent{
        private IPostRepository _postRapository;

        public NewPosts(IPostRepository postRapository){
            _postRapository = postRapository;
        }

       public async Task<IViewComponentResult> InvokeAsync(){
            return View(await _postRapository
                        .Posts
                        .OrderByDescending(p=>p.Publishedon)
                        .Take(5)
                        .ToListAsync());
        }
    }
}