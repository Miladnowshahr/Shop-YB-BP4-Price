using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopYB.Areas.Admin.Models.ViewModels;
using ShopYB.Areas.Admin.ViewModels;
using ShopYB.Models;

namespace ShopYB.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin", AuthenticationSchemes = "Admin_Schema")]

    [Area("admin")]
    [Route("admin/product")]
    public class ProductController : Controller
    {
        private DatabaseContext db;

        public ProductController(DatabaseContext _db)
        {
            db = _db;
        }
        
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            ViewBag.products = db.Products.ToList();
            return View();
        }


        [HttpGet]
        [Route("add")]
        public IActionResult Add()
        {
            var viewModel = new ProductViewModel();
            viewModel.Product = new Product();



            viewModel.Category = new List<SelectListItem>();
            var categories = db.Category.ToList();

            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };

                if (category.InverseParents!=null && category.InverseParents.Count>0)
                {
                    foreach (var subcategory in category.InverseParents)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subcategory.Name,
                            Value = subcategory.Id.ToString(),
                            Group=group
                        };
                        viewModel.Category.Add(selectListItem);
                    }
                }
            }
            return View(viewModel);
        }
        
        [HttpPost]
        [Route("add")]
        public IActionResult Add(ProductViewModel productViewModel)
        {
            productViewModel.Product.View = 0;

           

            db.Products.Add(productViewModel.Product);

            
            db.SaveChanges();

            var defaultPhoto = new Photo
            {
                Name = "no-image.png",
                Status = true,
                ProductId = productViewModel.Product.Id,
                Featured = true
            };
            db.Photos.Add(defaultPhoto);

            //to save in product price table
            var productPrice = new ProductPrice()
            {
                BasePrice = productViewModel.Product.Price,
                CreateDate = DateTime.Now.Date,
                ProductId = productViewModel.Product.Id,
                IsActive = true,
                ExpirayDate = DateTime.Now.AddDays(365)
            };
            db.ProductPrices.Add(productPrice);

            db.SaveChanges();

            return RedirectToAction("Index", "Product", new { area = "admin" });
        }


        [HttpGet]
        [Route("edit/{id}")]
        public IActionResult Edit(int id)
        {

            var viewModel = new ProductViewModel();
            viewModel.Product = db.Products.Find(id);



            viewModel.Category = new List<SelectListItem>();
            var categories = db.Category.ToList();

            foreach (var category in categories)
            {
                var group = new SelectListGroup { Name = category.Name };

                if (category.InverseParents != null && category.InverseParents.Count > 0)
                {
                    foreach (var subcategory in category.InverseParents)
                    {
                        var selectListItem = new SelectListItem
                        {
                            Text = subcategory.Name,
                            Value = subcategory.Id.ToString(),
                            Group = group
                        };
                        viewModel.Category.Add(selectListItem);
                    }
                }
            }


            return View(viewModel);
        }

        [HttpPost]
        [Route("edit/{id}")]
        public IActionResult Edit(int id,ProductViewModel productViewModel)
        {

            db.Entry(productViewModel.Product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("index", "product", new { area = "admin" });


        }


        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var product = db.Products.Find(id);
                if (product!=null)
                {
                    var priceTable = product.ProductPrices;

                    var productDiscount = product.PDiscounts;
                    var productPhoto = product.Photos;
                    var productInvoice = product.InvoiceDetails;
                    var productComment=product.Comments;

                    var commentlike = product.Comments;

                    foreach (var item in commentlike)
                    {
                        db.LikeDislikes.RemoveRange(item.LikeDislikes);
                    }

                    db.Photos.RemoveRange(productPhoto);
                    db.ProductPrices.RemoveRange(priceTable);
                    db.Comments.RemoveRange(productComment);
                    db.InvoiceDetails.RemoveRange(productInvoice);
                    db.Products.Remove(product);
                    db.SaveChanges();

                }

            }
            catch (Exception e)
            {
                TempData["Error"] = e.Message;

            }
            return RedirectToAction("index", "product", new { area = "admin" });

        }


        [HttpGet]
        [Route("chnagePrice/{id}")]
        public IActionResult CahngePrice(int id)
        {
            var model = db.ProductPrices.Where(x => x.ProductId == id).Last();

            var priceViewModel = new PriceViewModel() 
            {
                BasePrice=model.BasePrice,
                ProductId=id,
                ProductName=model.Product.Name
            };


            return View(priceViewModel);
        }

        [HttpPost]
        [Route("changePrice")]
        public IActionResult ChangePrice(PriceViewModel model)
        {
           
            var pricetable = new ProductPrice
            {
                ProductId = model.ProductId,
                BasePrice = model.NewPrice,
                CreateDate = DateTime.Now,
                ExpirayDate = model.ExpirayDate,
                IsActive = true
            };

            db.ProductPrices.Add(pricetable);
            db.SaveChanges();
            return RedirectToAction("index");
            

        }

        [HttpGet]
        [Route("discount/{id}")]
        public IActionResult Discount(int id)
        {
            var model = db.ProductPrices.Where(x => x.ProductId == id).Last();

            var discountViewModel = new DiscountViewModel()
            {
                Price = model.BasePrice,
                ProductId = id,
                ProductName = model.Product.Name,
                
            };

            return View(discountViewModel);
        }


        [HttpPost]
        [Route("discount/{id}")]
        public IActionResult Discount(int id,DiscountViewModel model)
        {
            PDiscount discount = new PDiscount();
            discount.ValidFrom = model.ValidFrom;
            discount.ProductId = model.ProductId;
            
            //when  valid from todau is activve is true
            discount.IsActive = model.IsActive;
            discount.DiscountValue = model.DiscountValue;
            discount.ExpirayDate = model.ExpirayDate;
            discount.CreateDate = DateTime.Now;

            db.PDiscounts.Add(discount);

            //if valid from now
            var pricetable = new ProductPrice();
            pricetable.ProductId = model.ProductId;
            pricetable.IsActive = true;
            pricetable.ExpirayDate = model.ExpirayDate;
            pricetable.CreateDate = DateTime.Now;
            pricetable.BasePrice = (int)(((double)100 - model.DiscountValue) * model.Price)/100;

            var qPriceTable = db.ProductPrices.Where(x => x.ProductId == model.ProductId && x.IsActive == true).OrderByDescending(x => x.CreateDate).ThenBy(x => x.Id).Take(1).Single();

            qPriceTable.IsActive = false;


            db.ProductPrices.Add(pricetable);
            db.SaveChanges();
            return RedirectToAction("index");

        }
    }
}