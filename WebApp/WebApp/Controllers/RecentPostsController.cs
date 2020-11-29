using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class RecentPostsController : Controller
    {
        private readonly ILogger<RecentPostsController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;

        public RecentPostsController(ApplicationDbContext context, ILogger<RecentPostsController> logger, UserManager<AppUser> manager)
        {
            _userManager = manager;
            _logger = logger;
            _context = context;
        }
        public IActionResult RecentPosts()
        {
            var posts = _context.Posts.OrderByDescending(a => a.Time);
            return View(posts);
        }
    }
}
