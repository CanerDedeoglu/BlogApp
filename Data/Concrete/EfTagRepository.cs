using BlogAPP.Data.Abstract;
using BlogAPP.Entity;
using BlogAPP.Entity.Concrete.EfCore;

namespace BlogAPP.Data.Concrete
{
    public class EfTagRepository : ITagRepository
    {
        private readonly BlogContext _context;

        public EfTagRepository(BlogContext context)
        {
            _context = context;
        }

        public IQueryable<Tag> Tags => _context.Tags;

        public void CreatePost(Tag tag)
        {
          _context.Tags.Add(tag);
            _context.SaveChanges();
        }
    }
}