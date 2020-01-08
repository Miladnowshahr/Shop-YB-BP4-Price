using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Areas.Admin.Models.ViewModels;
using ShopYB.Models;

namespace Shop_YB.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin", AuthenticationSchemes = "Admin_Schema")]
    [Route("admin/home")]
    [Area("admin")]
    [Route("admin/dashboard")]
    [Route("admin")]
    public class DashBoardController : Controller
    {
        private DatabaseContext db;

        public DashBoardController(DatabaseContext _db)
        {
            db = _db;
        }
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.NewOrder = db.Invoices.Where(x => x.Status == 1).Count();
            ViewBag.CountProducts = db.Products.Count();
            ViewBag.TotalSales = db.InvoiceDetails.Sum(x => x.Price * x.Quantity);
            ViewBag.CountCustomer = db.RoleAccount.Count(r=>r.RoleId==2);
            ViewBag.Comment = db.Comments.Count(c => c.IsRead == false);

            var daysMonth = DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month);

            var dates = db.Invoices.Where(x=>x.Created.Year==DateTime.Now.Year && x.Created.Month==DateTime.Now.Month).OrderBy(x=>x.Created).Select(x=>x.Created).ToList();
            var lineChart = new List<SaleLineChart>();

            //foreach (var item in dates)
            //{
            //    lineChart.Add(new SaleLineChart
            //    {
            //        Quantity=db.Invoices.Where(i=>i.Created==item).Count(),
            //        Date = item.Day
            //    });

            //}




            for (int i = 1; i < daysMonth; i++)
            {
                lineChart.Add(new SaleLineChart
                {
                    Quantity = db.Invoices.Where(o => o.Created.Year ==DateTime.Now.Year && o.Created.Month==DateTime.Now.Month && o.Created.Day==i ).Count(),
                    Date = i
                });
            }

            ViewBag.Chart = lineChart;

            return View(lineChart);
        }
    }
}