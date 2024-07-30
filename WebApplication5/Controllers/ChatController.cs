using Microsoft.AspNetCore.Mvc;
using WebApplication5.Services;
using WebApplication5.Hubs;
using WebApplication5.Models.DTOs;

using WebApplication5.Models;


namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService _chatService;

        public ChatController(IChatService chatService)
        {
            _chatService = chatService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageDto dto)
        {
            var result = await _chatService.SendMessageAsync(dto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("active-users")]
        public async Task<IActionResult> GetActiveUsers()
        {
            var users = await _chatService.GetActiveUsersAsync();
            return Ok(users);
        }

        // Additional endpoints for files, voice recordings, etc.
    }
}
