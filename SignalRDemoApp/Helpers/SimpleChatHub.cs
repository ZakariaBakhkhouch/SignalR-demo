using Microsoft.AspNetCore.SignalR;

namespace SignalRDemoApp.Helpers
{
    public class SimpleChatHub : Hub
    {
        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}
