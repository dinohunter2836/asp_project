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
    public class PostsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context, ILogger<HomeController> logger, UserManager<AppUser> manager)
        {
            _userManager = manager;
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Posts()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            var posts = _context.Posts.Where(a => a.User.Id == currentUser.Id);
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.CurrentUserName = currentUser.UserName;
            }
            return View(posts);
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(Post post)
        {
            if (ModelState.IsValid)
            {
                var sender = await _userManager.GetUserAsync(User);
                post.User = sender;
                post.UserId = sender.Id;
                post.UserName = sender.UserName;
                await _context.Posts.AddAsync(post);
                await _context.SaveChangesAsync();
                _logger.LogTrace($"User {post.UserName} created post saying {post.Text}");
                return RedirectToAction("Posts");
            }
            _logger.LogError($"Failed to create post");
            return Error();
        }

        [HttpGet]
        [Route("/Posts/DeletePost/{postId}")]
        public IActionResult DeletePost(string postId)
        {
            var post = _context.Posts.Find(int.Parse(postId));
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {
            try
            {
                var post = _context.Posts.Find(id);
                _context.Posts.Remove(post);
                foreach (var comment in _context.Comments.Where(c => c.PostId == id))
                {
                    _context.Comments.Remove(comment);
                }
                await _context.SaveChangesAsync();
                _logger.LogTrace($"User {post.UserName} deleted post saying {post.Text}");
                return RedirectToAction("Posts");
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Error();
            }
        }

        [HttpGet]
        [Route("/Posts/UserPosts/{userId}")]
        public IActionResult UserPosts(string userId)
        {
            var user = _context.Users.Find(userId);
            var posts = _context.Posts.Where(a => a.UserId == userId);
            ViewBag.CurrentUserName = user.UserName;
            return View(posts);
        }

        [HttpGet]
        [Route("/Posts/DeleteUserPost/{postId}")]
        public IActionResult DeleteUserPost(string postId)
        {
            var post = _context.Posts.Find(int.Parse(postId));
            ViewBag.UserId = post.UserId;
            return View(post);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteUserPost(int id)
        {
            try
            {
                var post = _context.Posts.Find(id);
                string userId = post.UserId;
                _context.Posts.Remove(post);
                foreach (var comment in _context.Comments.Where(c => c.PostId == id))
                {
                    _context.Comments.Remove(comment);
                }
                await _context.SaveChangesAsync();
                _logger.LogTrace($"Admin deleted post by {post.UserName} saying {post.Text}");
                return RedirectToAction("UserPosts", new { userId });
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
