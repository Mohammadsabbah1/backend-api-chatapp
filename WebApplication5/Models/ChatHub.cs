using Microsoft.AspNetCore.SignalR;

namespace WebApplication5.Models
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }

        public async Task SendFile(string user, byte[] fileData)
        {
            await Clients.All.SendAsync("ReceiveFile", user, fileData);
        }

        public async Task SendVoice(string user, byte[] voiceData)
        {
            await Clients.All.SendAsync("ReceiveVoice", user, voiceData);
        }
    }

}
