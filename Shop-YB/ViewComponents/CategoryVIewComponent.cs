using Microsoft.AspNetCore.Mvc;
using ShopYB.Helper;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.ViewComponents
{
    [ViewComponent(Name ="Category")]
    public class CategoryVIewComponent:ViewComponent
    {
        private DatabaseContext db;

        public CategoryVIewComponent(DatabaseContext _db)
        {
            db = _db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Category> categories = db.Category.Where(x => x.Status && x.Parent == null).ToList();
            return View("Index",categories);
        }
    }
}
