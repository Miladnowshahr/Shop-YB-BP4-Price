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
    [Route("admin/photo")]
    public class PhotoController : Controller
    {
        private DatabaseContext db;
        private IHostingEnvironment ihostingEnvironment;

        public PhotoController(DatabaseContext _db, IHostingEnvironment _hostingEnvironment)
        {
            db = _db;
            ihostingEnvironment = _hostingEnvironment;
        }

        [Route("index/{id}")]
        public IActionResult Index(int id)
        {
            ViewBag.Product = db.Products.Find(id).Name;
            ViewBag.Photos = db.Photos.Where(p => p.ProductId == id).ToList();
            return View();
        }
        [HttpGet]
        [Route("add/{id}")]
        public IActionResult Add(int id)
        {
            ViewBag.Product = db.Products.Find(id).Name;

            var photo = new Photo()
            {
                ProductId = id
            };
            return View(photo);
        }

        [HttpPost]
        [Route("add/{productId}")]
        public IActionResult Add(int productId, Photo model, IFormFile photo)
        {
            var filename = DateTime.Now.ToString("MMddyyyyhhmmss") + photo.FileName;

            var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "products",
                filename);

            var stream = new FileStream(path, FileMode.Create);


            //check for featured

            if (model.Featured)
            {
                var modelFeatured = db.Photos.SingleOrDefault(x => x.ProductId == productId && x.Featured == true);
                modelFeatured.Featured = false;
                db.Entry(modelFeatured).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                
            }


            photo.CopyToAsync(stream);
            model.Name = filename;
            db.Photos.Add(model);
            db.SaveChanges();


            return RedirectToAction("index", "photo", new { area = "admin", id = productId });
        }


        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var model = db.Photos.Find(id);
            db.Photos.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index", "photo", new { area = "admin",id=model.ProductId });

        }

        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var model = db.Photos.Find(id);
            ViewBag.Product = db.Products.Find(model.ProductId).Name;

            return View(model);

        }


        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id, Photo photoModel, IFormFile photo)
        {
            var model = db.Photos.Find(photoModel.Id);
            if (photo != null && !string.IsNullOrEmpty(photo.FileName))
            {
                var filename = DateTime.Now.ToString("MMddyyyyhhmmss") + photo.FileName;

                var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "products",
                    filename);

                var stream = new FileStream(path, FileMode.Create);
                photo.CopyToAsync(stream);
                model.Name = filename;

            }

            //check for featured

            if (photoModel.Featured)
            {
                var modelFeatured = db.Photos.SingleOrDefault(x => x.ProductId == model.ProductId && x.Featured == true);
                modelFeatured.Featured = false;
                db.Entry(modelFeatured).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }


            model.Status = photoModel.Status;
            model.Featured = photoModel.Featured;
            db.SaveChanges();
            return RedirectToAction("index", "photo", new { area = "admin" ,id=model.ProductId});


        }
        [HttpGet]
        [Route("setFeatured/{id}")]
        public IActionResult setFeatured(int id)
        {
            var photo = db.Photos.Find(id);
            var model = db.Photos.SingleOrDefault(p => p.ProductId == photo.ProductId && p.Featured == true);

            model.Featured = false;
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            photo.Featured = true;
            db.SaveChanges();
            return RedirectToAction("index", "photo", new { area = "admin", id = model.ProductId });

        }

    }
}