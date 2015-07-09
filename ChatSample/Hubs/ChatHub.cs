using Microsoft.AspNet.SignalR;

namespace ChatSample.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }
    }
}