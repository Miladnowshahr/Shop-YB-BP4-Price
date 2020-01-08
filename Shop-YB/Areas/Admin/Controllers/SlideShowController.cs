using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;

namespace ShopYB.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin", AuthenticationSchemes = "Admin_Schema")]

    [Area("admin")]
    [Route("admin/slideshow")]
    public class SlideShowController : Controller
    {
        private DatabaseContext db;

        private IHostingEnvironment ihostingEnvironment;

        public SlideShowController(DatabaseContext _db,IHostingEnvironment _hostingEnvironment)
        {
            db = _db;
            ihostingEnvironment = _hostingEnvironment;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.slideshows = db.SlideShow.ToList();

            return View();
        }


        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var model = new SlideShow();
            return View(model);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add(SlideShow slideshow,IFormFile photo)
        {
            var filename = DateTime.Now.ToString("MMddyyyyhhmmss") + photo.FileName;

            var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "slideshows",
                filename);

            var stream = new FileStream(path, FileMode.Create);
            photo.CopyToAsync(stream);
            slideshow.Name = filename;
            db.SlideShow.Add(slideshow);
            db.SaveChanges();


            return RedirectToAction("index", "slideshow", new { area = "admin" });
        }


        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var model = db.SlideShow.Find(id);
            db.SlideShow.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index", "SlideShow", new { area = "admin" });

        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = db.SlideShow.Find(id);

            return View(model);

        }


        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, SlideShow slideShow,IFormFile photo)
        {
            var model = db.SlideShow.Find(slideShow.Id);
            if (photo!=null && !string.IsNullOrEmpty(photo.FileName))
            {
                var filename = DateTime.Now.ToString("MMddyyyyhhmmss") + photo.FileName;

                var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "slideshows",
                    filename);

                var stream = new FileStream(path, FileMode.Create);
                photo.CopyToAsync(stream);
                model.Name = filename;

            }


            model.Status = slideShow.Status;
            model.Description = slideShow.Description;
            model.Title = slideShow.Title;
            db.SaveChanges();
            return RedirectToAction("index", "SlideShow", new { area = "admin" });


        }
    }
}