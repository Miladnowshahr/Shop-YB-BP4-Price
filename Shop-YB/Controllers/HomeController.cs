using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;
using SmartBreadcrumbs.Attributes;

namespace Shop_YB.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {

        private DatabaseContext db;

        public HomeController(DatabaseContext _db)
        {
            db = _db;
        }



        [Route("home")]
        [Route("/")]
        [DefaultBreadcrumb("گیل‌شرق")]

        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.IsHome = true;

            var model = db.PDiscounts.Where(x => x.IsActive == true && x.ExpirayDate > DateTime.Now.Date && x.ValidFrom <= DateTime.Now.Date);

            List<ShowDPViewModel> discountProduct = new List<ShowDPViewModel>();

            foreach (var item in model)
            {
                var price = db.ProductPrices.Where(x => x.ProductId == item.ProductId && x.IsActive == false).OrderByDescending(x => x.CreateDate).ThenByDescending(x => x.Id).Take(1).Single().BasePrice;
                discountProduct.Add(new ShowDPViewModel
                {
                   ExprireDate=item.ExpirayDate,
                    product = db.Products.Find(item.ProductId),
                    Price = price,
                    DiscountValue = item.DiscountValue,
                    NewPrice=(int)((100-item.DiscountValue)*price)/100
                });
            }
            ViewBag.Discount = discountProduct;

            var featuredProduct = db.Products.OrderByDescending(o => o.Id).Where(p => p.Featured && p.Status).ToList();

            ViewBag.FeaturedProduct = featuredProduct;


            ViewBag.CountFeaturedProduct = featuredProduct.Count();

            ViewBag.LatestProducts = db.Products.OrderByDescending(o => o.Id).Where(p => p.Status).Take(6).ToList();

            ViewBag.MaxSales = db.InvoiceDetails.GroupBy(x => x.Product).Select(x => new { productId = x.Key, count = x.Count() }).OrderByDescending(x => x.count).Select(x => x.productId);

            ViewBag.Basket = TempData["Basket"];
            return View();
        }

        [HttpGet]
        [Route("contactUs")]
        public IActionResult ContactUs()
        {
          

            return View();

        }

        [HttpPost]
        [Route("contactUs")]
        public IActionResult ContactUs(ContactUs contact)
        {
            contact.Date = DateTime.Now;
            contact.IsRead = false;
            db.ContactUs.Add(contact);
            db.SaveChanges();
            ViewBag.Message = "پیام شما با موفقیت ثبت شد.";
            return View();

        }

        [HttpGet]
        [Route("aboutUs")]
        public IActionResult AboutUs()
        {
            var model = db.Configs.FirstOrDefault();
            return View(model);
        }

        [Route("termPolicy")]
        public IActionResult TermPolicy()
        {

            var model = db.Configs.FirstOrDefault().TermPolicy;
            return View(model);
        }
    }
}