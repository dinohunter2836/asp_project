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
    [Authorize]
    public class CommentsController : Controller
    {
        private readonly ILogger<RecentPostsController> _logger;
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _context;

        public CommentsController(ApplicationDbContext context, ILogger<RecentPostsController> logger, UserManager<AppUser> manager)
        {
            _userManager = manager;
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("/Comments/Comments/{postId}")]
        public IActionResult Comments(string postId)
        {
            ViewBag.PostId = postId;
            var comments = _context.Comments.Where(c => c.PostId == int.Parse(postId))
                .OrderByDescending(c => c.Time);
            return View(comments);
        }

        [HttpGet]
        [Route("/Comments/UserComments/{userId}")]
        public IActionResult UserComments(string userId)
        {
            var user = _context.Users.Find(userId);
            var comments = _context.Comments.Where(c => c.UserName == user.UserName)
                .OrderByDescending(c => c.Time);
            ViewBag.UserId = userId;
            return View(comments);
        }


        [HttpGet]
        [Route("/Comments/CreateComment/{postId}")]
        public IActionResult CreateComment(string postId)
        {
            ViewBag.PostId = postId;
            return View();
        }

        [HttpPost]
        [Route("/Comments/CreateComment/{postId}")]
        public async Task<IActionResult> CreateComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.Id = 0;
                var sender = await _userManager.GetUserAsync(User);
                comment.UserName = sender.UserName;
                comment.Post = _context.Posts.Find(comment.PostId);
                await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction("Comments", new { postId = comment.PostId });
            }
            return Error();
        }

        [HttpGet]
        [Route("/Comments/DeleteComment/{commentId}")]
        public IActionResult DeleteComment(string commentId)
        {
            var comment = _context.Comments.Find(int.Parse(commentId));
            var post = _context.Posts.Find(comment.PostId);
            ViewBag.UserId = post.UserId;
            return View(comment);
        }

        [HttpPost]
        public IActionResult DeleteComment(int id)
        {
            var comment = _context.Comments.Find(id);
            var post = _context.Posts.Find(comment.PostId);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Comments", new { postId = post.Id });
        }

        [HttpGet]
        [Route("/Comments/DeleteUserComment/{commentId}")]
        public IActionResult DeleteUserComment(string commentId)
        {
            var comment = _context.Comments.Find(int.Parse(commentId));
            return View(comment);
        }

        [HttpPost]
        public IActionResult DeleteUserComment(int id)
        {
            var comment = _context.Comments.Find(id);
            var userId = _context.Posts.Find(comment.PostId).UserId;
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("UserComments", new { userId });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
