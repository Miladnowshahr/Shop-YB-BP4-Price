using Microsoft.AspNetCore.Mvc;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.ViewComponents
{
    [ViewComponent(Name ="SlideShow")]
    public class SlideShowVIewComponent : ViewComponent
    {
        private DatabaseContext db;

        public SlideShowVIewComponent(DatabaseContext _db)
        {
            db = _db;
        }
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<SlideShow> slideShows = db.SlideShow.Where(x => x.Status).ToList();

            return View("index",slideShows);
        }
    }
}
