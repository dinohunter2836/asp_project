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
using WebApp.Services;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly Logger _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context, Logger logger, UserManager<AppUser> manager)
        {
            _userManager = manager;
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var messages = _context.Messages.Where(a => true);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
                ViewBag.UserId = currentUser.Id;
            }
            return View(messages);
        }

        [HttpGet]
        [Route("/Home/DeleteMessage/{messageId}")]
        public IActionResult DeleteMessage(string messageId)
        {
            var message = _context.Messages.Find(int.Parse(messageId));
            return View(message);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteMessage(int id)
        {
            try
            {
                var message = _context.Messages.Find(id);
                _context.Messages.Remove(message);
                await _context.SaveChangesAsync();
                _logger.LogTrace($"Deleted message by {message.UserName} saying {message.Text}");
                return RedirectToAction("Index");
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
