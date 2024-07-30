using WebApplication5.Models;
using WebApplication5.Models.DTOs;

namespace WebApplication5.Services
{
    public interface IChatService
    {
        Task<Result> SendMessageAsync(SendMessageDto dto);
        Task<IEnumerable<UserDto>> GetActiveUsersAsync();
    }
}
