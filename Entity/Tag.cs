namespace BlogAPP.Entity
{
    public class Tag
    {
        public int TagId { get; set; }

        public string? Name { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}