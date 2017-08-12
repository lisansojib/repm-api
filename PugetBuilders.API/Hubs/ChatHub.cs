using Microsoft.AspNet.SignalR;

namespace PugetBuilders.API.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        public void Send(string name, string message)
        {
            var user = Context.User.Identity.Name;
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}