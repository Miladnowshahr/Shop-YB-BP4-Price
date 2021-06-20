using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;
using ShopYB.Security;

namespace ShopYB.Controllers
{
    [Route("customer")]
    public class CustomerController : Controller
    {
        private DatabaseContext db;
        private SecurityManager securityManager = new SecurityManager();

        public CustomerController(DatabaseContext _db)
        {
            db = _db;
        }

        [HttpGet]
        [Route("register")]
        public IActionResult Register()
        {
            var account = new Account();
            return View(account);
        }

        [HttpPost]
        [Route("register")]
        public IActionResult Register(Account account)
        {
            var exists = db.Account.Count(a => a.Username.Equals(account.Username)) > 0;

            if (!exists)
            {
                account.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
                account.Status = true;
                db.Account.Add(account);
                db.SaveChanges();
                // ad role custimer to new Account
                var roleAccount = new RoleAccount()
                {
                    RoleId = 2,
                    AccountId = account.Id,
                    Status = true
                };
                db.RoleAccount.Add(roleAccount);
                db.SaveChanges();
                return RedirectToAction("login", "Account");
            }
            else
            {
                ViewBag.error = "Username exists";
                return View("Register", account);
            }
        }

        [HttpGet]
        [Route("login")]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            var account = ProcessLogin(loginViewModel.UserName, loginViewModel.Password);

            if (account != null)
            {
                securityManager.SignIn(this.HttpContext, account, "User_Schema");
                var refer = HttpContext.Request.Headers["Referer"].ToString();

                if (!string.IsNullOrEmpty(loginViewModel.ReturnUrl))
                {
                    return RedirectToAction(loginViewModel.ReturnUrl);
                }
                if (refer.Contains("cart"))
                {
                    return RedirectToAction("shipping", "cart");
                }
                return RedirectToAction("dashboard", "customer");
            }
            else
            {
                var refer = HttpContext.Request.Headers["Referer"].ToString();
                if (!refer.Contains("cart"))
                {
                    ViewBag.error = "نام کاربری یا رمز عبور اشتباه می باشد";
                }
            }

            var model = new LoginViewModel();

            return View("login", model);
        }

        [Route("signout")]
        public IActionResult Signout()
        {
            securityManager.SignOut(this.HttpContext, "User_Schema");
            return View("login");
        }

        [HttpGet]
        [Route("accessdenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }

        private Account ProcessLogin(string username, string password)
        {
            var account = db.Account.SingleOrDefault(a => a.Username.Equals(username) && a.Status == true);

            if (account != null)
            {
                var roleAccount = account.RoleAccounts.FirstOrDefault();

                if (roleAccount.RoleId == 2 && roleAccount.Status == true && BCrypt.Net.BCrypt.Verify(password, account.Password.Trim()))
                {
                    return account;
                }
            }
            return null;
        }

        [Authorize(Roles = "customer", AuthenticationSchemes = "User_Schema")]
        [HttpGet]
        [Route("profile")]
        public IActionResult Profile()
        {
            var user = User.FindFirst(ClaimTypes.Name);

            var customer = db.Account.SingleOrDefault(a => a.Username.Equals(user.Value));

            return View(customer);
        }

        [Authorize(Roles = "customer", AuthenticationSchemes = "User_Schema")]
        [HttpPost]
        [Route("Profile")]
        public IActionResult Profile(Account account)
        {
            var curCustomer = db.Account.Find(account.Id);
            if (!string.IsNullOrEmpty(account.Password))
            {
                curCustomer.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            }
            curCustomer.FullName = account.FullName;
            curCustomer.Email = account.Email;
            curCustomer.Phone = account.Phone;
            db.Entry(curCustomer).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return View(curCustomer);
        }

        [Authorize(Roles = "customer", AuthenticationSchemes = "User_Schema")]
        [HttpGet]
        [Route("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        //Invoice
        [Authorize(Roles = "customer", AuthenticationSchemes = "User_Schema")]
        [HttpGet]
        [Route("history")]
        public IActionResult History()
        {
            var user = User.FindFirst(ClaimTypes.Name);
            var customer = db.Account.SingleOrDefault(a => a.Username.Equals(user.Value));
            ViewBag.Invoices = customer.Invoices.ToList();

            return View();
        }

        [Authorize(Roles = "customer", AuthenticationSchemes = "User_Schema")]
        [HttpGet]
        [Route("details/{id}")]
        public IActionResult Details(int id)
        {
            ViewBag.InvoiceDetails = db.InvoiceDetails.Where(x => x.InvoiceId == id).ToList();
            return View();
        }

        [HttpGet]
        public JsonResult Detail(int id)
        {
            var model = db.InvoiceDetails.Where(x => x.InvoiceId == id).ToList();
            return Json(model);
        }

        public int AddAddress(Address address)
        {
            //address.InvoiceId = 1;
            db.Addresses.Add(address);
            db.SaveChanges();
            return db.SaveChanges();
        }
    }
}