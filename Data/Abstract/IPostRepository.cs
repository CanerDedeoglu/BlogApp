using BlogAPP.Entity;

namespace BlogAPP.Data.Abstract
{
    public interface IPostRepository
    {
     
     IQueryable<Post> Posts { get; }

     void CreatePost(Post post);

    }
}