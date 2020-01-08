using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.ViewComponents
{
    [ViewComponent(Name ="LatestProducts")]
    public class LatestProductsVIewComponent : ViewComponent
    {
        private DatabaseContext db;

        public LatestProductsVIewComponent(DatabaseContext _db)
        {
            db = _db;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Product> latestProducts = db.Products.OrderByDescending(o => o.Id).Where(p => p.Status).Take(2).ToList();

            return View("index", latestProducts);
        }
    }
}
