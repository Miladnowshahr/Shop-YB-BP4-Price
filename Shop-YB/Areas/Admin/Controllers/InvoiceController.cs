using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jsreport.AspNetCore;
using jsreport.Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;

namespace ShopYB.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin",AuthenticationSchemes ="Admin_Schema")]
    [Area("admin")]
    [Route("admin/invoice")]
    public class InvoiceController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public InvoiceController(DatabaseContext _db)
        {
            db = _db;
        }



        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.Invoices = db.Invoices.OrderByDescending(o=>o.Id).ToList();
            return View();
        }

        [Route("detail/{id}")]
        public IActionResult Detail(int id)
        {
            var invoice = db.Invoices.Find(id);
            //var payment = db.Payments.FirstOrDefault(x => x.InvoiceId == id).PayMethods;
         
            
            ViewBag.Invoices = invoice;
            ViewBag.Payment = invoice.Payments.PayMethods;
            return View(invoice);
        }


        [HttpPost]
        [Route("process")]
        public IActionResult Process(int id)
        {
            
            var invoice = db.Invoices.Find(id);
            invoice.Status = 2;
            db.SaveChanges();

            return RedirectToAction("Index", "invoice", new { area = "admin" });
        }



        [Route("invoicePdf/{id}")]
        [MiddlewareFilter(typeof(JsReportPipeline))]
        public IActionResult InvoicePdf(int id)
        {
           
            HttpContext.JsReportFeature().Recipe(Recipe.ChromePdf);
            ViewBag.Invoices = db.Invoices.Find(id);
            return View("detail");
        }



    }
}