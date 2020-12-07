﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Models;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class PrivateMessagesController : Controller
    {
        private readonly Logger _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;
        private readonly IdCombiner _combiner;

        public PrivateMessagesController(ApplicationDbContext context, Logger logger, UserManager<AppUser> manager,
            IdCombiner combiner)
        {
            _userManager = manager;
            _logger = logger;
            _context = context;
            _combiner = combiner;
        }

        [HttpGet]
        public async Task<IActionResult> Users()
        {
            var user = await _userManager.GetUserAsync(User);
            var users = new List<SelectListItem>();
            foreach (var _user in _context.Users.Where(u => !u.Id.Equals(user.Id)))
            {
                users.Add(new SelectListItem() { Text = _user.UserName, Value = _user.Id });
            }
            return View(new SelectUserViewModel { Users = users });
        }

        [HttpPost]
        public async Task<IActionResult> Users(SelectUserViewModel holder)
        {
            var user = await _userManager.GetUserAsync(User);
            var userId = user.Id;
            string secondUserId = holder.secondUserId;
            string combinedId = _combiner.CombineIds(userId, secondUserId);
            return RedirectToAction("Chat", new { combinedId });
        }

        [Route("/PrivateMessages/Chat/{combinedId}")]
        public async Task<IActionResult> Chat(string combinedId)
        {
            try
            {
                var sender = await _userManager.GetUserAsync(User);
                var receiver = await _context.Users.FindAsync(_combiner.SplitIds(combinedId, sender));
                ViewBag.CombinedId = combinedId;
                ViewBag.ReceiverUserName = receiver.UserName;

                var messages = _context.PrivateMessages.Where(m => 
                (m.SenderID == sender.Id && m.ReceiverID == receiver.Id) || 
                (m.ReceiverID == sender.Id && m.SenderID == receiver.Id));

                return View(messages);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Error();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
