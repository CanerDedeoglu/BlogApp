namespace BlogAPP.Entity
{
    public class Post
    {
        public int PostId { get; set; }

        public string? Title { get; set; } 

        public string? Content { get; set; }

        public string? Image { get; set; }

        public bool isActive { get; set; }

        public DateTime Publishedon { get; set; }

        public int UserId { get; set; }

        public User User { get; set; } = null!;

        public List<Comment> Comments { get; set; } = new List<Comment>();

        public List<Tag> Tags { get; set; } = new List<Tag>();
    }
}