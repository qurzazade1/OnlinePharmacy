using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.Models.ViewModels;
using OnlinePharmacy.WebShopUtility;
using Stripe;

namespace OnlinePharmacy.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerCartController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IEmailSender _emailSender;


        [BindProperty]
        public CustomerOrderDetailsCart customerDetailCart { get; set; }

        public CustomerCartController(ApplicationDbContext db, IEmailSender emailSender)
        {
            _db = db;
            _emailSender = emailSender;

        }

        public async Task<IActionResult> Index()
        {
            if (ModelState.IsValid) { 
            customerDetailCart = new CustomerOrderDetailsCart()
            {
                CustomerOrderHeader = new Models.CustomerOrderHeader()
            };

            customerDetailCart.CustomerOrderHeader.OrderTotal = 0;

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                if (claim == null)
                {
                    return RedirectToAction("Index","Home");
                }

            var cart = _db.CustomerShoppingCart.Where(c => c.ApplicationUserId == claim.Value);
            if (cart != null)
            {
                customerDetailCart.listCart = cart.ToList();
            }

            foreach (var list in customerDetailCart.listCart)
            {
                list.Medicine = await _db.Medicine.FirstOrDefaultAsync(m => m.Id == list.MedicineId);
                customerDetailCart.CustomerOrderHeader.OrderTotal = customerDetailCart.CustomerOrderHeader.OrderTotal + (list.Medicine.Price * list.Count);
                list.Medicine.Description = SD.ConvertToRawHtml(list.Medicine.Description);
                if (list.Medicine.Description.Length > 100)
                {
                    list.Medicine.Description = list.Medicine.Description.Substring(0, 99) + "...";
                }
            }
            customerDetailCart.CustomerOrderHeader.OrderTotalOriginal = customerDetailCart.CustomerOrderHeader.OrderTotal;

            if (HttpContext.Session.GetString(SD.ssDiscountCodeString) != null)
            {
                customerDetailCart.CustomerOrderHeader.DiscountCodeString = HttpContext.Session.GetString(SD.ssDiscountCodeString);
                var discountCodeFromDb = await _db.DiscountCode.Where(c => c.Name.ToLower() == customerDetailCart.CustomerOrderHeader.DiscountCodeString.ToLower()).FirstOrDefaultAsync();
                customerDetailCart.CustomerOrderHeader.OrderTotal = SD.DiscountedPrice(discountCodeFromDb, customerDetailCart.CustomerOrderHeader.OrderTotalOriginal);
            }


            return View(customerDetailCart);
        }
        else{
                return RedirectToAction("Index", "Home");
        }
        }


        public async Task<IActionResult> Checkout()
        {

            customerDetailCart = new CustomerOrderDetailsCart()
            {
                CustomerOrderHeader = new Models.CustomerOrderHeader()
            };

            customerDetailCart.CustomerOrderHeader.OrderTotal = 0;

            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            ApplicationUser ApplicationUser = await _db.ApplicationUser.Where(c => c.Id == claim.Value).FirstOrDefaultAsync();
            var cart = _db.CustomerShoppingCart.Where(c => c.ApplicationUserId == claim.Value);
            if (cart != null)
            {
                customerDetailCart.listCart = cart.ToList();
            }

            foreach (var list in customerDetailCart.listCart)
            {
                list.Medicine = await _db.Medicine.FirstOrDefaultAsync(m => m.Id == list.MedicineId);
                customerDetailCart.CustomerOrderHeader.OrderTotal = customerDetailCart.CustomerOrderHeader.OrderTotal + (list.Medicine.Price * list.Count);

            }
            customerDetailCart.CustomerOrderHeader.OrderTotalOriginal = customerDetailCart.CustomerOrderHeader.OrderTotal;
            customerDetailCart.CustomerOrderHeader.PickupName = ApplicationUser.Name;
            customerDetailCart.CustomerOrderHeader.PhoneNumber = ApplicationUser.PhoneNumber;
            customerDetailCart.CustomerOrderHeader.PickUpTime = DateTime.Now;


            if (HttpContext.Session.GetString(SD.ssDiscountCodeString) != null)
            {
                customerDetailCart.CustomerOrderHeader.DiscountCodeString = HttpContext.Session.GetString(SD.ssDiscountCodeString);
                var discountCodeFromDb = await _db.DiscountCode.Where(c => c.Name.ToLower() == customerDetailCart.CustomerOrderHeader.DiscountCodeString.ToLower()).FirstOrDefaultAsync();
                 customerDetailCart.CustomerOrderHeader.OrderTotal = SD.DiscountedPrice(discountCodeFromDb, customerDetailCart.CustomerOrderHeader.OrderTotalOriginal);
            }


            return View(customerDetailCart);

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Checkout")]
        public async Task<IActionResult> CheckoutPost(string stripeEmail, string stripeToken)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


            customerDetailCart.listCart = await _db.CustomerShoppingCart.Where(c => c.ApplicationUserId == claim.Value).ToListAsync();

            customerDetailCart.CustomerOrderHeader.PaymentStatus = SD.PaymentStatusPending;
            customerDetailCart.CustomerOrderHeader.OrderDate = DateTime.Now;
            customerDetailCart.CustomerOrderHeader.UserId = claim.Value;
            customerDetailCart.CustomerOrderHeader.Status = SD.PaymentStatusPending;
            customerDetailCart.CustomerOrderHeader.PickUpTime = Convert.ToDateTime(customerDetailCart.CustomerOrderHeader.PickUpDate.ToShortDateString() + " " + customerDetailCart.CustomerOrderHeader.PickUpTime.ToShortTimeString());

            List<CustomerCustomerOrderDetails> CustomerOrderDetailsList = new List<CustomerCustomerOrderDetails>();
            _db.CustomerOrderHeader.Add(customerDetailCart.CustomerOrderHeader);
            await _db.SaveChangesAsync();

            customerDetailCart.CustomerOrderHeader.OrderTotalOriginal = 0;


            foreach (var item in customerDetailCart.listCart)
            {
                item.Medicine = await _db.Medicine.FirstOrDefaultAsync(m => m.Id == item.MedicineId);
                CustomerCustomerOrderDetails CustomerOrderDetails = new CustomerCustomerOrderDetails
                {
                    MedicineId = item.MedicineId,
                    OrderId = customerDetailCart.CustomerOrderHeader.Id,
                    Description = item.Medicine.Description,
                    Name = item.Medicine.Name,
                    Price = item.Medicine.Price,
                    Count = item.Count
                };
                customerDetailCart.CustomerOrderHeader.OrderTotalOriginal += CustomerOrderDetails.Count * CustomerOrderDetails.Price;
                _db.CustomerOrderDetails.Add(CustomerOrderDetails);

            }

            if (HttpContext.Session.GetString(SD.ssDiscountCodeString) != null)
            {
                customerDetailCart.CustomerOrderHeader.DiscountCodeString = HttpContext.Session.GetString(SD.ssDiscountCodeString);
                var discountCodeFromDb = await _db.DiscountCode.Where(c => c.Name.ToLower() == customerDetailCart.CustomerOrderHeader.DiscountCodeString.ToLower()).FirstOrDefaultAsync();
           customerDetailCart.CustomerOrderHeader.OrderTotal = SD.DiscountedPrice(discountCodeFromDb, customerDetailCart.CustomerOrderHeader.OrderTotalOriginal);
            }
            else
            {
                customerDetailCart.CustomerOrderHeader.OrderTotal = customerDetailCart.CustomerOrderHeader.OrderTotalOriginal;
            }
            customerDetailCart.CustomerOrderHeader.DiscountCodeDiscountedAmount = customerDetailCart.CustomerOrderHeader.OrderTotalOriginal - customerDetailCart.CustomerOrderHeader.OrderTotal;

            _db.CustomerShoppingCart.RemoveRange(customerDetailCart.listCart);
            HttpContext.Session.SetInt32(SD.ssCustomerShoppingCartCount, 0);
            await _db.SaveChangesAsync();

            //Stripe Logic

            if (stripeToken != null)
            {
                var customers = new CustomerService();
                var charges = new ChargeService();

                var customer = customers.Create(new CustomerCreateOptions
                {
                    Email = stripeEmail,
                    SourceToken = stripeToken
                });

                var charge = charges.Create(new ChargeCreateOptions
                {
                    Amount = Convert.ToInt32(customerDetailCart.CustomerOrderHeader.OrderTotal * 100),
                    Description = "Order ID : " + customerDetailCart.CustomerOrderHeader.Id,
                    Currency = "usd",
                    CustomerId = customer.Id
                });

                customerDetailCart.CustomerOrderHeader.TransactionId = charge.BalanceTransactionId;
                if (charge.Status.ToLower() == "succeeded")
                {
                    //email for successful order
                    await _emailSender.SendEmailAsync(_db.Users.Where(u => u.Id == claim.Value).FirstOrDefault().Email, "Online Pharmacy - Order Created " + customerDetailCart.CustomerOrderHeader.Id.ToString(), "Order has been submitted successfully.");

                    customerDetailCart.CustomerOrderHeader.PaymentStatus = SD.PaymentStatusApproved;
                    customerDetailCart.CustomerOrderHeader.Status = SD.StatusSubmitted;
                }
                else
                {
                    customerDetailCart.CustomerOrderHeader.PaymentStatus = SD.PaymentStatusRejected;
                }

            }
            else
            {
                customerDetailCart.CustomerOrderHeader.PaymentStatus = SD.PaymentStatusRejected;
            }

            await _db.SaveChangesAsync();


     
           return RedirectToAction("Confirm", "CustomerOrder", new { id = customerDetailCart.CustomerOrderHeader.Id });

        }






        public async Task<IActionResult> Plus(int cartId)
        {
            var cart = await _db.CustomerShoppingCart.FirstOrDefaultAsync(c => c.Id == cartId);
            cart.Count += 1;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Minus(int cartId)
        {
            var cart = await _db.CustomerShoppingCart.FirstOrDefaultAsync(c => c.Id == cartId);
            if (cart.Count == 1)
            {
                _db.CustomerShoppingCart.Remove(cart);
                await _db.SaveChangesAsync();

                var cnt = _db.CustomerShoppingCart.Where(u => u.ApplicationUserId == cart.ApplicationUserId).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssCustomerShoppingCartCount, cnt);
            }
            else
            {
                cart.Count -= 1;
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Remove(int cartId)
        {
            var cart = await _db.CustomerShoppingCart.FirstOrDefaultAsync(c => c.Id == cartId);

            _db.CustomerShoppingCart.Remove(cart);
            await _db.SaveChangesAsync();

            var cnt = _db.CustomerShoppingCart.Where(u => u.ApplicationUserId == cart.ApplicationUserId).ToList().Count;
            HttpContext.Session.SetInt32(SD.ssCustomerShoppingCartCount, cnt);


            return RedirectToAction(nameof(Index));
        }
        public IActionResult AddDiscountCode()
        {
            if (customerDetailCart.CustomerOrderHeader.DiscountCodeString == null)
            {
                customerDetailCart.CustomerOrderHeader.DiscountCodeString = "";
            }
            HttpContext.Session.SetString(SD.ssDiscountCodeString, customerDetailCart.CustomerOrderHeader.DiscountCodeString);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult RemoveDiscountCode()
        {

            HttpContext.Session.SetString(SD.ssDiscountCodeString, string.Empty);

            return RedirectToAction(nameof(Index));
        }





























    }
}