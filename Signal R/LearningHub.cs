using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SignalR
{
    public class LearningHub :Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage" , user, message);
        }
    }
}
