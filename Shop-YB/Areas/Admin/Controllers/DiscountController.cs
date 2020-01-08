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
    [Route("admin/discount")]
    public class DiscountController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public DiscountController(DatabaseContext _db)
        {
            db = _db;
        }

        [Route("CategoryDiscount")]
        [HttpGet]
        public IActionResult CategoryDiscount()
        {
            ViewBag.Category = db.Category.Where(x=>x.ParentId==null).ToList();
            return View();
        }

        [Route("CategoryDiscount")]

        [HttpPost]
        public IActionResult CategoryDiscount(ProductCategoryDiscount model)
        {
            model.Create_Date = DateTime.Now;

            db.ProductCategoryDiscounts.Add(model);
            db.SaveChanges();

            return View();
        }
    }
}