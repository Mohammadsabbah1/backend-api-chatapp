namespace WebApplication5.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int ChatId { get; set; }
        public string Content { get; set; }
        public bool IsSeen { get; set; }
        public DateTime SentAt { get; set; }
        public string FilePath { get; set; }
    }
}
