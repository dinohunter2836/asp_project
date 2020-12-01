using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;
        public AdminController(ApplicationDbContext context, ILogger<HomeController> logger, UserManager<AppUser> manager)
        {
            _userManager = manager;
            _logger = logger;
            _context = context;
        }
        public IActionResult Admin()
        {
            var users = _context.Users.Where(a => true).OrderBy(a => a.UserName);
            return View(users);
        }

        [HttpGet]
        [Route("/Admin/UserMessages/{userId}")]
        public IActionResult UserMessages(string userId)
        {
            var user = _context.Users.Find(userId);
            ViewBag.UserId = user.Id;
            var messages = _context.Messages.Where(m => m.UserName == user.UserName).OrderByDescending(m => m.Time);
            return View(messages);
        }

        [HttpGet]
        [Route("/Admin/DeleteMessage/{messageId}")]
        public IActionResult DeleteMessage(string messageId)
        {
            var message = _context.Messages.Find(int.Parse(messageId));
            return View(message);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            var message = _context.Messages.Find(id);
            var user = await _userManager.FindByNameAsync(message.UserName);
            _context.Messages.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction("UserMessages", new { userId = user.Id});
        }

        [Route("/Admin/GiveModRole/{userId}")]
        public async Task<IActionResult> GiveModRole(string userId)
        {
            var user = _context.Users.Find(userId);
            await _userManager.AddToRoleAsync(user, "chatModerator");
            return RedirectToAction("UserMessages", new { userId = user.Id });
        }

        [Route("/Admin/RemoveModRole/{userId}")]
        public async Task<IActionResult> RemoveModRole(string userId)
        {
            var user = _context.Users.Find(userId);
            await _userManager.RemoveFromRoleAsync(user, "chatModerator");
            return RedirectToAction("UserMessages", new { userId = user.Id });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
