using WebApplication5.Models;
using WebApplication5.Services;
using WebApplication5.Models.DTOs;
using Microsoft.EntityFrameworkCore;



public class ChatService : IChatService
{
    private readonly ApplicationDbContext _context;

    public ChatService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Result> SendMessageAsync(SendMessageDto dto)
    {
        var message = new Message
        {
            ChatId = dto.ChatId,
            Content = dto.Content,
            SentAt = DateTime.UtcNow,
            IsSeen = false,
        };

        _context.Messages.Add(message);
        await _context.SaveChangesAsync();

        return new Result { Success = true, Message = "Message sent successfully." };
    }

    public async Task<IEnumerable<UserDto>> GetActiveUsersAsync()
    {
        var activeUsers = await _context.Users
            .Where(u => u.IsActive)
            .Select(u => new UserDto { Id = u.Id, UserName = u.UserName })
            .ToListAsync();

        return activeUsers;
    }
}
