namespace WebApplication5.Models.DTOs
{
    public class FileUploadDto
    {
        public IFormFile File { get; set; }
        public int ChatId { get; set; }
        public int SenderId { get; set; }
    }
}
