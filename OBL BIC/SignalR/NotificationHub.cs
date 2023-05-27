using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace OBL.BIC.SignalR
{
    [Authorize]
    public class NotificationHub :Hub
    {
        //public async Task SendNotification(string message)
        //{
        //    await Clients.All.SendAsync("ReceiveNotification", message);
        //}
        private static Dictionary<string, string> userConnections = new Dictionary<string, string>();

        public override async Task OnConnectedAsync()
        {
            string userId = Context.UserIdentifier;
            string connectionId = Context.ConnectionId;

            // Store the connectionId for the user
            userConnections[userId] = connectionId;

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            string userId = Context.UserIdentifier;

            // Remove the connectionId when the user disconnects
            if (userConnections.ContainsKey(userId))
            {
                userConnections.Remove(userId);
            }

            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendNotificationToUser(string userId, string message)
        {
            if (userConnections.TryGetValue(userId, out string connectionId))
            {
                await Clients.Client(connectionId).SendAsync("ReceiveNotification", message);
            }
        }
    }
}
