using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.ViewComponents
{
    [ViewComponent(Name ="Search")]
    public class SearchViewComponent : ViewComponent
    {
        private DatabaseContext db;

        public SearchViewComponent(DatabaseContext _db)
        {
            db = _db;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string keyword = HttpContext.Request.Query["keyword"].ToString();

            int categoryId = -1;
            if (HttpContext.Request.Query.ContainsKey("categoryId"))
            {
                categoryId = int.Parse(HttpContext.Request.Query["categoryId"].ToString());
            }

            List<Category> Categories = db.Category.Where(x => x.Status && x.Parent==null).ToList();
            
            return View("index",new InvokeResult() { Categories=Categories,categoryId=categoryId,keyword=keyword});
        }
    }

    public class InvokeResult
    {
        public string keyword { get; set; }
        
        public int categoryId { get; set; }
        public List<Category> Categories { get; set; }
    }
}
