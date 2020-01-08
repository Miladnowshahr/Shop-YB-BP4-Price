using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;

namespace ShopYB.Areas.Admin.Controllers
{
    [Authorize(Roles ="admin",AuthenticationSchemes ="Admin_Schema")]
    [Area("admin")]
    [Route("admin/category")]
    public class CategoryController : Controller
    {
        private DatabaseContext db = new DatabaseContext();

        public CategoryController(DatabaseContext _db)
        {
            db = _db;
        }



        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.categories = db.Category.Where(x=>x.Parent==null).ToList();
            return View();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var model = new Category();
            return View(model);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(Category category)
        {
            category.Parent = null;
            db.Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("index", "category", new { area = "admin" });
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var model = db.Category.Find(id);
            db.Category.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index", "category", new { area = "admin" });

        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = db.Category.Find(id);
            
            return View(model);

        }


        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id,Category category)
        {
            var model = db.Category.Find(id);

            model.Name = category.Name;
            model.Status = category.Status;
            db.SaveChanges();
            return RedirectToAction("index", "category", new { area = "admin" });


        }

        [HttpGet]
        [Route("addsubcategory/{id}")]
        public IActionResult AddSubCategory(int id)
        {
            var category = new Category()
            {
                ParentId = id
            };

            return View(category);
        }


        [HttpPost]
        [Route("addsubcategory/{categoryid}")]
        public IActionResult AddSubCategory(int categoryid, Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();
            return RedirectToAction("index", "category", new { area = "admin" });


        }



    }
}