using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Controllers;
using WebApp.Data;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly Logger _logger;
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(ApplicationDbContext context, Logger logger, UserManager<AppUser> manager)
        {
            _context = context;
            _logger = logger;
            _userManager = manager;
        }
        public async Task SendMessage(Message message)
        {
            try
            {
                await _context.Messages.AddAsync(message);
                await _context.SaveChangesAsync();
                await Clients.All.SendAsync("receiveMessage", message);
                _logger.LogTrace($"User {message.UserName} has sent message saying {message.Text} to public chat");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
        }
    }
}
