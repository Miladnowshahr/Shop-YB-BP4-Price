using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopYB.Helper;
using ShopYB.Models;
using PARSGREEN.CORE.RESTful.SMS;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using SmartBreadcrumbs.Attributes;

namespace Shop_YB.Controllers
{
    [Route("cart")]
    public class CartController : Controller
    {
        private DatabaseContext db;

        public CartController(DatabaseContext _db)
        {
            db = _db;
        }


        [Route("index")]
        [Breadcrumb("سبد خرید", FromAction = "Index", FromController = typeof(HomeController))]
        public IActionResult Index()
        {
            List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");


            if (SessionHelper.GetObjectFromJson(HttpContext.Session, "cart") == null)
            {
                ViewBag.Cart = null;
                ViewBag.CountItems = 0;
            }
            else
            {
                ViewBag.Cart = cart;
                ViewBag.CountItems = cart.Count;
            }

            ViewBag.Basket = TempData["Basket"];
            return View();
        }


        [HttpGet]
        [Route("buy/{id}")]
        public IActionResult buy(int id, int? quantity)
        {

            int quant = quantity ?? 1;
            var product = db.Products.Find(id);
            var price = db.ProductPrices.FirstOrDefault(x => x.IsActive && x.ProductId == id).BasePrice;
            double discountValue = 0;
            var basePrice = 0;
            if (db.PDiscounts.Any(x => x.IsActive && x.ProductId == id))
            {
                discountValue = db.PDiscounts.FirstOrDefault(x => x.ProductId == id && x.IsActive).DiscountValue;
                basePrice = (int)((100 * price) / (100 - discountValue))-price;
            } 
            
            List<Item> lstC = new List<Item>();
            if (SessionHelper.GetObjectFromJson(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = product,
                    Quantity = quant,
                    PhotoName = db.Photos.SingleOrDefault(x => x.ProductId == product.Id && x.Featured).Name,
                    Price=price,
                    Discount=discountValue,
                    BasePrice=basePrice
                    
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                lstC = cart;
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");
                int index = exists(id, cart);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = product,
                        Quantity = quant,
                        PhotoName = db.Photos.SingleOrDefault(x => x.ProductId == product.Id && x.Featured).Name,
                        Price = price,
                        Discount = discountValue,
                        BasePrice = basePrice
                    });
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                else
                {
                    int newQuantity = cart[index].Quantity + quant;
                    cart[index].Quantity = newQuantity;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

                }
                lstC = cart;

            }
            TempData["Basket"] = lstC.Count();
            return RedirectToAction("index", "cart");
        }


        [Route("buyJson")]
        [HttpPost]
        public JsonResult buyJson(int id, int? quantity)
        {
            int quant = quantity ?? 1;
            var product = db.Products.Find(id);

            var price = db.ProductPrices.FirstOrDefault(x => x.IsActive && x.ProductId == id).BasePrice;
            double discountValue = 0;
            var basePrice = 0;
            if (db.PDiscounts.Any(x => x.IsActive && x.ProductId == id))
            {
                discountValue = db.PDiscounts.FirstOrDefault(x => x.ProductId == id && x.IsActive).DiscountValue;
                basePrice = (int)((100 * price) / (100 - discountValue)) - price;
            }

            List<Item> lstC = new List<Item>();
            if (SessionHelper.GetObjectFromJson(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item
                {
                    Product = product,
                    Quantity = quant,
                    PhotoName = db.Photos.SingleOrDefault(x => x.ProductId == product.Id && x.Featured).Name,
                    Price = price,
                    Discount = discountValue,
                    BasePrice = basePrice
                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                lstC = cart;
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");
                int index = exists(id, cart);
                if (index == -1)
                {
                    cart.Add(new Item
                    {
                        Product = product,
                        Quantity = quant,
                        PhotoName = db.Photos.SingleOrDefault(x => x.ProductId == product.Id && x.Featured).Name,
                        Price = price,
                        Discount = discountValue,
                        BasePrice = basePrice
                    });
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                }
                else
                {
                    int newQuantity = quant;
                    cart[index].Quantity = newQuantity;
                    SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

                }
                lstC = cart;

            }
            TempData["Basket"] = lstC.Count;
            return Json(true);
        }


        //2
        [Authorize(Roles = "customer", AuthenticationSchemes = "User_Schema")]
        [HttpGet]
        [Route("shipping")]
        public IActionResult Shipping()
        {
            var user = User.FindFirst(ClaimTypes.Name);
            var customer = db.Account.SingleOrDefault(a => a.Username.Equals(user.Value));
            ViewBag.CustomerId = customer.Id;
            var address = db.Addresses.Where(a => a.AccountId == customer.Id).ToList();
            ViewBag.Address = address;
            List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");
            ViewBag.Invoice = cart;

            //side
            ViewBag.Ship = 1;
            if (cart != null)
            {

                var totalPrice = cart.Sum(x => x.Quantity * x.Price);
                ViewBag.TotalPrice = totalPrice;

                ViewBag.Quantity = cart.Count();
                if (totalPrice > 150000)
                {
                    ViewBag.Shipping = 0;
                }
                else
                    ViewBag.Shipping = 8000;
            }
            CheckoutViewModel model = new CheckoutViewModel();

            return View(model);
        }

        //3
        [Route("payment")]
        [HttpPost]
        public IActionResult Payment(CheckoutViewModel model)
        {

            return View(model);

        }

        public IActionResult Pay(CheckoutViewModel model)
        {

            return RedirectToAction("Checkout");
        }

        //4
        [Route("checkout")]
        public IActionResult Checkout(CheckoutViewModel model)
        {


            if (model.ShipMethod==3 && model.Pay==2)
            {
                ModelState.AddModelError("", "این روش امکان پذیر نمی باشد.");
                return View("Payment",model);
            }
            var user = User.FindFirst(ClaimTypes.Name);

            if (user == null)
            {
                return RedirectToAction("Login", "customer");
            }
            else
            {

                var customer = db.Account.SingleOrDefault(a => a.Username.Equals(user.Value));

                db.Database.EnsureCreated();
                // crete new Invoice
                var invoice = new Invoice()
                {
                    Name = "Inv",
                    Created = DateTime.Now,
                    Status = 1,
                    AccountId = customer.Id
                };

                db.Invoices.Add(invoice);




                //Ship 
                var ship = new Ship();

                ship.AddressId = model.Id;
                ship.InvoiceId = invoice.Id;

                ship.Price = (model.TotalPrice > 1500000) ? 0 : 8000;
                //else
                if (model.ShipMethod == 3)
                {
                    ship.Price = 0;
                }
                else if ((model.ShipMethod==4) && ship.Price>1000000) 
                {
                    ship.Price = 0;
                }

                ship.ShipMethod = model.ShipMethod;


                db.Ships.Add(ship);



                //Create invoice Details
                var invoiceDetials = new List<InvoiceDetails>();
                List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");
                foreach (var item in cart)
                {
                    invoiceDetials.Add(new InvoiceDetails()
                    {
                        InvoiceId = invoice.Id,
                        ProductId = item.Product.Id,
                        Price = item.Price,
                        Quantity = item.Quantity
                    });
                }
                db.InvoiceDetails.AddRange(invoiceDetials);

                //zarinpal

                var payonline = new ZarinpalSandbox.Payment(model.TotalPrice);
                var res = payonline.PaymentRequest($"پرداخت شماره فاکتور {invoice.Id}", "http://localhost:56503/cart/checkPay/" + invoice.Id);

                if (res.Result.Status == 100)
                {
                    return Redirect("https://sandbox.zarinpal.com/pg/startpay/" + res.Result.Authority);
                }
                else
                    return BadRequest();




                //Pay
                var pay = new Payment()
                {
                    AccountId = customer.Id,
                    Amount = model.TotalPrice,
                    InvoiceId = invoice.Id,
                    PayMethodId = model.Pay,
                    Status = true,
                    Date = DateTime.Now
                };

                db.Payments.Add(pay);

                db.SaveChanges();

                var phone = db.Addresses.Find(model.Id).Phone;

                //twilio
                //  var sid = "AC740b46957eebd103c79ac49f2b90c6f4";
                //var token = "702995b5adbed075d749ef84839d6638";

                //TwilioClient.Init(sid, token);

                //var _message = MessageResource.Create(
                //    body: "خرید شما با موفقیت انجام شد",
                //    from: new Twilio.Types.PhoneNumber("+14125153394"),
                //    to: new Twilio.Types.PhoneNumber("+98"+phone)
                //);
                //var res = _message.Sid;

                if (model.Pay==1)
                {
                    ModelState.AddModelError("", "امکان ارتباط با سرور بانک مقدور نمی باشد..");
                    return View("Payment", model);
                }
                return RedirectToAction("Thanks", "cart");

            }

        }




        //5
        [Route("thanks")]
        public IActionResult Thanks()
        {

            //pasrs green
            //var mobile = "09116319715";
            //var text = "123";
            //string _signature = "D062B0E5-9BFC-455A-A2E2-ED3366FA2D22";
            //var message = new Message(_signature);
            //var result = message.SendOtp( mobile, text,0,true);


            //ViewBag.Result = result;
            //remove items in cart
            HttpContext.Session.Remove("cart");
            return View();
        }

        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson(HttpContext.Session, "cart");
            int index = exists(id, cart);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("index", "cart");

        }


        public IActionResult CheckPay(int id)
        {
            if ((HttpContext.Request.Query["status"] !="") && (HttpContext.Request.Query["status"].ToString().ToLower()=="ok") && (HttpContext.Request.Query["Authority"]!=""))
            {
                string authority = HttpContext.Request.Query["Authority"].ToString();
                var order = db.Invoices.FirstOrDefault(x => x.Id == id);

                var payment = new ZarinpalSandbox.Payment(order.Payments.Amount);
                var res = payment.Verification(authority).Result;

                if (res.Status==100)
                {

                    order.Status = 1;
                    order.Payments.Status = true;
                    db.Entry(order).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    ViewBag.RefCode = res.RefId;
                    TempData["RefCode"] = res.RefId;
                    return RedirectToAction("thanks");
                }
                ViewBag.ErrorCode = res.Status;
                return View("ErrorOnlinePay");
            }
            ViewBag.ErrorCode = "متاسفانه جوابی از درگاه بانکی دریافت نشده است";
            return View("ErrorOnlinePay");

        }





        private int exists(int id, List<Item> cart)
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.Id == id)
                {
                    return i;
                }
            }
            return -1;

        }
    }
}