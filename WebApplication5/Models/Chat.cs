namespace WebApplication5.Models
{
    public class Chat
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AdminId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
