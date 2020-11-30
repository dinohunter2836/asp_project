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

namespace WebApp.Hubs
{
    public class ChatHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;

        public ChatHub(ApplicationDbContext context, ILogger<HomeController> logger, UserManager<AppUser> manager)
        {
            _context = context;
            _logger = logger;
            _userManager = manager;
        }
        public async Task SendMessage(Message message)
        {
            await _context.Messages.AddAsync(message);
            await _context.SaveChangesAsync();
            await Clients.All.SendAsync("receiveMessage", message);
        }

    }
}
