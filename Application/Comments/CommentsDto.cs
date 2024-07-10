namespace Application.Comments
{
    public class CommentsDto
    {
        public int Id { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
        public string Body { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Image { get; set; }
    }
}