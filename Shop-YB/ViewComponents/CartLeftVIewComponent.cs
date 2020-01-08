using Microsoft.AspNetCore.Mvc;
using ShopYB.Helper;
using ShopYB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopYB.ViewComponents
{
    [ViewComponent(Name ="CartLeft")]
    public class CartLeftVIewComponent : ViewComponent
    {
        
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            if (SessionHelper.GetObjectFromJson(HttpContext.Session, "cart") == null)
            {
                ViewBag.Total = 0;
                ViewBag.CountItems = 0;
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");
                ViewBag.Total = cart.Sum(x => x.Quantity * x.Product.Price);

                ViewBag.CountItems = cart.Count;
            }
            return View("index");
        }
    }
}
