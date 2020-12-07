using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Hubs
{
    public class PrivateChatHub : Hub
    {
        private readonly ApplicationDbContext db;
        private readonly UserManager<AppUser> _userManager;
        private readonly IHttpContextAccessor _context;
        private readonly Logger _logger;
        public PrivateChatHub(ApplicationDbContext applicationContext, IHttpContextAccessor httpContextAccessor,
            UserManager<AppUser> userManager, Logger logger)
        {
            db = applicationContext;
            _userManager = userManager;
            _context = httpContextAccessor;
            _logger = logger;
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
            try
            {
                result.UserName = message.UserName;
                result.Text = message.Text;
                result.Time = message.Time;
                await Clients.Group(combinedId).SendAsync("receiveMessage", result);
                _logger.LogTrace($"User {message.UserName} has sent message to {receiverId} saying {message.Text}");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
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
                _logger.LogError(e.Message);
            }
        }
    }
}
