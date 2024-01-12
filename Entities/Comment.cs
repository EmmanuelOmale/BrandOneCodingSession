namespace BrandOneCodingSession.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }

        public string PostId { get; set; }
        public Post Post { get; set; }
    }
}