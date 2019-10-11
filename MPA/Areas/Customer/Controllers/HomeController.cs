using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.Models.ViewModels;
using OnlinePharmacy.WebShopUtility;
using Microsoft.AspNetCore.Identity;
namespace OnlinePharmacy.Controllers



{

    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IActionResult> Index()
        {
            CustomerIndexViewModel IndexVM = new CustomerIndexViewModel()
            {
                Medicine = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).ToListAsync(),
                MedicineType = await _db.MedicineType.ToListAsync(),
                DiscountCode = await _db.DiscountCode.Where(c => c.IsActive == true).ToListAsync()

            };

            var claimsIdentity = (ClaimsIdentity)User.Identity;

            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                var cnt = _db.CustomerShoppingCart.Where(u => u.ApplicationUserId == claim.Value).ToList().Count;
                HttpContext.Session.SetInt32(SD.ssCustomerShoppingCartCount, cnt);
            }



            return View(IndexVM);
        }


        [Authorize]
        public async Task<IActionResult> Details(int id)
        {
            var MedicineFromDb = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).Where(m => m.Id == id).FirstOrDefaultAsync();

            CustomerShoppingCart customercartObj = new CustomerShoppingCart()
            {
                Medicine = MedicineFromDb,

                MedicineId = MedicineFromDb.Id               
            };

            return View(customercartObj);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(CustomerShoppingCart CartObject)
        {
            CartObject.Id = 0;
            if (ModelState.IsValid)
            {
                var claimsIdentity = (ClaimsIdentity)this.User.Identity;
                var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
                CartObject.ApplicationUserId = claim.Value;

                CustomerShoppingCart cartFromDb = await _db.CustomerShoppingCart.Where(c => c.ApplicationUserId == CartObject.ApplicationUserId
                                                && c.MedicineId == CartObject.MedicineId).FirstOrDefaultAsync();

                if (cartFromDb == null)
                {
                    await _db.CustomerShoppingCart.AddAsync(CartObject);
                }
                else
                {
                    cartFromDb.Count = cartFromDb.Count + CartObject.Count;
                }
                await _db.SaveChangesAsync();

                var count = _db.CustomerShoppingCart.Where(c => c.ApplicationUserId == CartObject.ApplicationUserId).ToList().Count();
              
                HttpContext.Session.SetInt32(SD.ssCustomerShoppingCartCount, count);

                return RedirectToAction("Index");
            }
            else
            {

                var MenuItemFromDb = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).Where(m => m.Id == CartObject.MedicineId).FirstOrDefaultAsync();

                CustomerShoppingCart cartObj = new CustomerShoppingCart()
                {
                    Medicine = MenuItemFromDb,
                    MedicineId = MenuItemFromDb.Id
                };

                return View(cartObj);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
