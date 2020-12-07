using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Hubs
{
    public class PrivateChatHub : Hub
    {
        private ApplicationDbContext db;
        private UserManager<AppUser> _userManager;
        private IHttpContextAccessor _context;
        public PrivateChatHub(ApplicationDbContext applicationContext, IHttpContextAccessor httpContextAccessor,
            UserManager<AppUser> userManager)
        {
            db = applicationContext;
            _userManager = userManager;
            _context = httpContextAccessor;
        }

        public async Task SendMessage(PrivateMessage message)
        {
            string combinedId = Context.GetHttpContext().Request.Query["combinedId"].First().ToString();
            var sender = await _userManager.FindByNameAsync(message.UserName);
            string[] ids = combinedId.Split('_');
            string receiverId;
            if (ids[0].CompareTo(sender.Id) == 0)
            {
                receiverId = ids[1];
            } else
            {
                receiverId = ids[0];
            }
            message.ReceiverID = receiverId;
            message.SenderID = sender.Id;
            message.Sender = sender;
            db.PrivateMessages.Add(message);
            await db.SaveChangesAsync();
            Message result = new Message();
            result.UserName = message.UserName;
            result.Text = message.Text;
            result.Time = message.Time;
            await Clients.Group(combinedId).SendAsync("receiveMessage", result);
        }

        public override async Task OnConnectedAsync()
        {
            try
            {
                string combinedId = Context.GetHttpContext().Request.Query["combinedId"].First().ToString();
                await Groups.AddToGroupAsync(Context.ConnectionId, combinedId);
                await base.OnConnectedAsync();
            }
            catch (Exception e)
            {
                //_logger.LogError(e.Message);
            }
        }
    }
}
