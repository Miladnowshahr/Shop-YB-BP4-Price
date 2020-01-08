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
    [Route("admin/comment")]
    public class CommentController : Controller
    {
        private DatabaseContext db;

        public CommentController(DatabaseContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {

            var model = db.Comments.OrderByDescending(o => o.Id).ThenByDescending(o => o.Date_Time).ToList();
            return View(model);
        }
        
        [Route("changeSt/{id}")]
        public IActionResult ChangeSt(int id)
        {
            var model = db.Comments.Find(id);
            model.Status = model.Status? false:true ;
            model.IsRead = true;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var model = db.Comments.Find(id);
            db.Comments.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}

