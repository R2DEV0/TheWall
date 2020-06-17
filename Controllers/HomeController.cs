using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace TheWall.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
// ****************************************************** GET REQUEST ********************************************** //       
        // User Login & Reg Page //
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        

        // User main dashboard //
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? LoggedUser = HttpContext.Session.GetInt32("UserId");
            if(LoggedUser == null)
            {
                return View("Index");
            }
            PostCom Wall = new PostCom();
            Wall.AllMessages = dbContext.Messages.Include(m => m.ConnectedComments).ToList();
            Wall.AllComments = dbContext.Comments.ToList();
            Wall.AllUsers = dbContext.Users.ToList();
            ViewBag.User = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedUser);
            return View("Dashboard", Wall);
        }

// ****************************************************** POST REQUEST ********************************************** //  
        // Create a new User //
        [HttpPost("register")]
        public IActionResult Register(LoginReg FromForm)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == FromForm.UserForm.Email))
                {
                    ModelState.AddModelError("UserForm.Email", "Email is already in use!");
                    return Index();
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                FromForm.UserForm.Password = Hasher.HashPassword(FromForm.UserForm, FromForm.UserForm.Password);
                dbContext.Users.Add(FromForm.UserForm);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("UserId", FromForm.UserForm.UserId);
                return RedirectToAction("Dashboard");
            }
            return Index();
        }


        // login in existing User //
        [HttpPost("login")]
        public IActionResult Login(LoginReg FromForm)
        {
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u => u.Email == FromForm.LoggedUserForm.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoggedUserForm.Email", "Invalid Email/Password");
                    return Index();
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(FromForm.LoggedUserForm, userInDb.Password, FromForm.LoggedUserForm.Password);
                if(result == 0)
                {
                    ModelState.AddModelError("LoggedUserForm.Password", "Wrong Password");
                    return Index();
                }
                else
                {
                    HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                    return RedirectToAction("Dashboard");
                }
            }
            else
            {
                return Index();
            }
        }


        // for user to post a new message and it will be displayed on the dashboard //
        [HttpPost("postmessage")]
        public IActionResult PostMessage()
        {
            if(ModelState.IsValid)
            {
                int? userId = HttpContext.Session.GetInt32("UserId");
                string post = Request.Form["Post"];
                Message message = new Message(){UserId = (int)userId, Post = post};
                dbContext.Add(message);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return Dashboard();
        }


        // any user can reply to any post //
        [HttpPost("postcomment")]
        public IActionResult PostComment(int MessageId)
        {
            if(ModelState.IsValid)
            {
                int? userId = HttpContext.Session.GetInt32("UserId");
                int messageId = MessageId;
                string response = Request.Form["Response"];
                Comment comment = new Comment(){MessageId = messageId, UserId = (int)userId, Response = response};
                dbContext.Add(comment);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return Dashboard();
        }


        // Logout User //
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
