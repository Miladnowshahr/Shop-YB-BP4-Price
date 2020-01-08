using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;

namespace ShopYB.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin", AuthenticationSchemes = "Admin_Schema")]

    [Area("admin")]
    [Route("admin/customer")]

    public class CustomerController : Controller
    {

       
            private DatabaseContext db = new DatabaseContext();

            public CustomerController(DatabaseContext _db)
            {
                db = _db;
            }

        [Route("")]
        [Route("index")]
        public IActionResult Index(int id)
        {
            if (id==1)
            {
                ViewBag.Customer = db.Account.Where(a => a.RoleAccounts.FirstOrDefault().RoleId == 1).ToList();
                return View();
            }
            else
            {
                ViewBag.Customer = db.Account.Where(a => a.RoleAccounts.FirstOrDefault().RoleId == 2).ToList();
                return View();
            }
           
        }



        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            var customer = db.Account.Find(id);

            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(int id,Account account)
        {

            var customer = db.Account.Find(id);

            if (!string.IsNullOrEmpty(account.Password))
            {
                customer.Password = BCrypt.Net.BCrypt.HashPassword(account.Password);
            }

            customer.FullName = account.FullName;
            customer.Email = account.Email;
            customer.Status = account.Status;
            db.SaveChanges();
            return RedirectToAction("index", "customer", new { area = "admin" });

        }




    }
}