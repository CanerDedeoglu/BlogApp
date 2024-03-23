using BlogAPP.Entity;

namespace BlogAPP.Data.Abstract
{
    public interface ITagRepository
    {
     
     IQueryable<Tag> Tags { get; }

     void CreatePost(Tag tag);

    }
}