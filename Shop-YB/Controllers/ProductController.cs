using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop_YB.Controllers;
using ShopYB.Models;
using ShopYB.Models.ViewModels;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using X.PagedList;

namespace ShopYB.Controllers
{
    public class ProductController : Controller
    {
        private DatabaseContext db;

        public ProductController(DatabaseContext _db)
        {
            db = _db;
        }
        [Breadcrumb("ViewData.Detail", FromAction = "Category", FromController = typeof(ProductController))]
        public IActionResult Details(int id)
        {
            var model = db.Products.Find(id);
            model.View += 1;
            db.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();


          
            ViewBag.Product = model;
            ViewBag.RelatedProducts = db.Products.Where(p => p.CategoryId == model.CategoryId || p.CategoryId == model.Category.ParentId && p.Id != model.Id && p.Status).ToList();
            //comment
            ViewBag.Comment = db.Comments.Where(x => x.ProductId == model.Id && x.Status == true);

            ProductDetailViewModel productDetail = new ProductDetailViewModel
            {
                Comments = db.Comments.Where(x => x.ProductId == model.Id && x.Status == true),
                ProductPrice = db.ProductPrices.FirstOrDefault(p => p.ProductId == id && p.IsActive == true),
                Product = model,
                IsDiscount = db.PDiscounts.Any(x => x.ProductId == id && x.IsActive == true),
                RelatedProduct = db.Products.Where(p => p.CategoryId == model.CategoryId || p.CategoryId == model.Category.ParentId && p.Id != model.Id && p.Status).ToList()
            };



            // All you have to do now is tell SmartBreadcrumbs about this
            ViewData["Detail"] = model.Name; // Use the last node
            ViewData["Title1"] = model.Category.Name;


            return View(productDetail);
        }

        [Route("category")]

        [Breadcrumb("ViewData.Title1", FromAction = "Index", FromController = typeof(HomeController))]
        public IActionResult Category(string keyword, int? categoryId, int? page, int? order)
        {
            var pageNumber = page ?? 1;


            var lstProduct = new List<Product>();

            if (keyword != null)
            {
                lstProduct = db.Products.Where(x => x.Name.Contains(keyword) && x.Status).ToList();
            }
            else
            {
                lstProduct = db.Products.Where(x => x.Status).ToList();
            }
            ViewData["Title1"] = keyword;
            if (categoryId != null)
            {

                lstProduct = lstProduct.Where(x => x.Category.ParentId == categoryId).ToList();
                var category = db.Category.Find(categoryId);
                ViewBag.Category = category;
                ViewData["Title1"] = category.Name;
            }

            ViewBag.CountProduct = lstProduct.Count();



            //order by
            order = order ?? 3;
            ViewBag.Order = order;
            switch (order)
            {
                case 1:
                    ViewBag.Products = lstProduct.OrderBy(o => o.Name).ToList().ToPagedList(pageNumber, 8);
                    break;
                case 2:
                    ViewBag.Products = lstProduct.OrderByDescending(o => o.Name).ToList().ToPagedList(pageNumber, 8);

                    break;
                case 3:
                default:
                    ViewBag.Products = lstProduct.OrderByDescending(o => o.Id).ToList().ToPagedList(pageNumber, 8);

                    break;
                case 4:
                    ViewBag.Products = lstProduct.OrderBy(o => o.Price).ToList().ToPagedList(pageNumber, 8);

                    break;
                case 5:
                    ViewBag.Products = lstProduct.OrderByDescending(o => o.Price).ToList().ToPagedList(pageNumber, 8);

                    break;
                case 6:
                    ViewBag.Products = lstProduct.OrderByDescending(o => o.View).ToList().ToPagedList(pageNumber, 8);

                    break;

            }

            //var childNode1 = new MvcBreadcrumbNode("Index", "HomeController",category.Name);
            //ViewData["BreadcrumbNode"] = childNode1;
            return View("Category");
        }






        public JsonResult Comment(Comment comment)
        {

            var model = new Comment();
            model.Content = comment.Content;
            model.Date_Time = DateTime.Now;
            model.Email = comment.Email;
            model.FullName = comment.FullName;

            model.Status = false;
            model.ProductId = comment.ProductId;
            db.Comments.Add(model);
            int st = db.SaveChanges();
            if (st == 1)
            {
                return Json(1);
            }
            else
            {
                return Json(2);

            }
        }



        public JsonResult LikeDislike(int id, bool status)
        {
            try
            {
                var strIp = Request.HttpContext.Connection.RemoteIpAddress.ToString();

                var query = db.LikeDislikes.FirstOrDefault(x => x.UserIp.Equals(strIp) && x.CommentId == id);

                if (query == null)
                {
                    db.LikeDislikes.Add(new LikeDislike()
                    {
                        CommentId = id,
                        Status = status,
                        UserIp = strIp
                    });
                    db.SaveChanges();
                    return Json(1);
                }

                else if (query.Status != status)
                {
                    query.Status = status;
                    db.SaveChanges();
                    return Json(2);
                }
                else
                    return Json(3);
            }
            catch
            {
                return Json(20);

            }




        }
    }
}