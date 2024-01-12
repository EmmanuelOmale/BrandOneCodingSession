namespace BrandOneCodingSession.Entities
{
    public class Post : BaseEntity
    {
        public string Tittle { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
