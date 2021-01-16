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
    [Route("admin/config")]
    public class ConfigController : Controller
    {
        private IHostingEnvironment ihostingEnvironment;

        private DatabaseContext _db { get; set; }
        public ConfigController(DatabaseContext db, IHostingEnvironment _hostingEnvironment)
        {
            _db = db;
            ihostingEnvironment = _hostingEnvironment;
        }
       
        [Route("Index")]
        public IActionResult Index()
        {
            var model = _db.Configs.FirstOrDefault();
            return View(model);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var config = new Config();
            return View("Edit", config);
        }


        [Route("TermPolicy")]
        public IActionResult TermPolicy()
        {
            var model = _db.Configs.FirstOrDefault();
            return View(model);
        }


        public IActionResult TermPolicyEdit(string termPolicy)
        {
            var model=_db.Configs.FirstOrDefault();
            model.TermPolicy = termPolicy;
            _db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("index");
        }

      



        [HttpGet]
        [Route("edit")]
        public IActionResult Edit(int id)
        {
            var model = _db.Configs.Find(id);
            return View(model);
        }

        [HttpPost]
        [Route("save")]
        public IActionResult Save(int? id,Config model, IFormFile logo)
        {
            if (id==null || id==0)
            {
                string filename = "no-image.png";
                if (logo != null && !string.IsNullOrEmpty(logo.FileName))
                {
                    filename = DateTime.Now.ToString("MMddyyyyhhmmss") + logo.FileName;

                    var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "Logo",
                        filename);

                    var stream = new FileStream(path, FileMode.Create);
                    logo.CopyToAsync(stream);

                }
                var addConfig = new Config();
                addConfig.RecordNumber = model.RecordNumber;
                addConfig.Phone = model.Phone;
                addConfig.Name = model.Name;
                addConfig.Mobile = model.Mobile;
                addConfig.Email = model.Email;
                addConfig.Describe = model.Describe;
                addConfig.Address = model.Address;
                addConfig.Logo = filename;

                _db.Configs.Add(addConfig);
                    
                _db.SaveChanges();
            }
            else
            {
                var configEdit = _db.Configs.Find(model.Id);

                string filename = "no-image.png";
                if (logo != null && !string.IsNullOrEmpty(logo.FileName))
                {
                    filename = DateTime.Now.ToString("MMddyyyyhhmmss") + logo.FileName;

                    var path = Path.Combine(this.ihostingEnvironment.WebRootPath, "Logo",
                        filename);

                    var stream = new FileStream(path, FileMode.Create);
                    logo.CopyToAsync(stream);

                }


                configEdit.RecordNumber = model.RecordNumber;
                configEdit.Phone = model.Phone;
                configEdit.Name = model.Name;
                configEdit.Mobile = model.Mobile;
                configEdit.Email = model.Email;
                configEdit.Describe = model.Describe;
                configEdit.Address = model.Address;
                configEdit.Logo = filename;


                _db.Entry(configEdit).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

                _db.SaveChanges();
            }
           
            return RedirectToAction("index");
        }

    }
}