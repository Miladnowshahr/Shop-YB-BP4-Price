using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;
using ShopYB.Security;
namespace ShopYB.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/Login")]
    public class LoginController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        private SecurityManager securityManager = new SecurityManager();


        public LoginController(DatabaseContext _db)
        {
            db = _db;
        }


        [Route("")]
        [Route("index")]
        [Route("admin/login/login")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("admin/process")]
        public IActionResult Process(string username,string password)
        {
            var account = ProcessLogin(username, password);

            if (account != null)
            {
                securityManager.SignIn(this.HttpContext, account,"Admin_Schema");
                return RedirectToAction("index", "dashboard", new { area = "admin" });
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("index");
            }
        }

        private Account ProcessLogin(string username,string password)
        {
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username) && a.Status==true);

            if (account!=null)
            {
                var roleAccount = account.RoleAccounts.FirstOrDefault();

                if (roleAccount.RoleId==1 && roleAccount.Status==true && BCrypt.Net.BCrypt.Verify(password, account.Password.Trim()))
                {
                    return account; 
                }
            }
            return null; 
        }

        [Route("signout")]
        public IActionResult Signout()
        {
            securityManager.SignOut(this.HttpContext,"Admin_Schema");
            return RedirectToAction("index", "login");

        }

        [Authorize(Roles = "customer", AuthenticationSchemes = "Admin_Schema")]

        [HttpGet]
        [Route("profile")]
        public IActionResult Profile()
        {
            var user = User.FindFirst(ClaimTypes.Name);
            var username = user.Value;
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username));
            return View("profile",account);
        }

        [Authorize(Roles = "customer", AuthenticationSchemes = "Admin_Schema")]

        [HttpPost]
        [Route("profile")]
        public IActionResult Profile(Account account)
        {
            var currentAccount = db.Account.SingleOrDefault(x => x.Username.Equals(account.Username));
            if (!string.IsNullOrEmpty(account.Password))
            {
                currentAccount.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            }
            currentAccount.Email = account.Email;
            currentAccount.FullName = account.FullName;
            currentAccount.Username = account.Username;
            currentAccount.Phone = account.Phone;
            db.SaveChanges();
            ViewBag.msg = "Done";
            return View("profile");
        }


        [Route("accessdenied")]
        public IActionResult Accessdenid()
        {
            return View("Access Denied");
        }
    }
}