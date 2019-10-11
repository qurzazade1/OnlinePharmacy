using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.WebShopUtility;


namespace OnlinePharmacy.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.ManagerUser)]
    public class DiscountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DiscountController(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _db.DiscountCode.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DiscountCode discountCodes)
        {
            if(ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if(files.Count>0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    discountCodes.Picture = p1;
                }
                _db.DiscountCode.Add(discountCodes);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(discountCodes);
        }

        //GET Edit DiscountCode
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var discountCode = await _db.DiscountCode.SingleOrDefaultAsync(m => m.Id == id);
            if (discountCode == null)
            {
                return NotFound();
            }
            return View(discountCode);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DiscountCode discountCodes)
        {
            if (discountCodes.Id == 0)
            {
                return NotFound();
            }

            var discountCodeFromDb = await _db.DiscountCode.Where(c => c.Id == discountCodes.Id).FirstOrDefaultAsync();

            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files.Count > 0)
                {
                    byte[] p1 = null;
                    using (var fs1 = files[0].OpenReadStream())
                    {
                        using (var ms1 = new MemoryStream())
                        {
                            fs1.CopyTo(ms1);
                            p1 = ms1.ToArray();
                        }
                    }
                    discountCodeFromDb.Picture = p1;
                }
                discountCodeFromDb.MinimumAmount = discountCodes.MinimumAmount;
               discountCodeFromDb.Name = discountCodes.Name;
                discountCodeFromDb.DiscountAmount = discountCodes.DiscountAmount;
                discountCodeFromDb.DiscountCodeType= discountCodes.DiscountCodeType;
                discountCodeFromDb.IsActive = discountCodes.IsActive;

                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(discountCodes);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var discountCode = await _db.DiscountCode
                .FirstOrDefaultAsync(m => m.Id == id);
            if (discountCode == null)
            {
                return NotFound();
            }

            return View(discountCode);
        }

        //GET Delete DiscountCode
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var discountCode = await _db.DiscountCode.SingleOrDefaultAsync(m => m.Id == id);
            if (discountCode == null)
            {
                return NotFound();
            }
            return View(discountCode);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var discountCode = await _db.DiscountCode.SingleOrDefaultAsync(m => m.Id == id);
            _db.DiscountCode.Remove(discountCode);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}