using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.WebShopUtility;

namespace Spice.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles =SD.ManagerUser)]
    public class MedicineTypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MedicineTypeController(ApplicationDbContext db)
        {
            _db = db;
        }


        //GET 
        public async Task<IActionResult> Index()
        {
            return View(await _db.MedicineType.ToListAsync());
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View();
        }


        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MedicineType MedicineType)
        {
            if(ModelState.IsValid)
            {
                //if valid
                _db.MedicineType.Add(MedicineType);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));

            }
            return View(MedicineType);
        }


        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var MedicineType = await _db.MedicineType.FindAsync(id);
            if(MedicineType==null)
            {
                return NotFound();
            }
            return View(MedicineType);
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(MedicineType MedicineType)
        {
            if(ModelState.IsValid)
            {
                _db.Update(MedicineType);
                await _db.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(MedicineType);
        }



        //GET - DELETE
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var MedicineType = await _db.MedicineType.FindAsync(id);
            if (MedicineType == null)
            {
                return NotFound();
            }
            return View(MedicineType);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            var MedicineType = await _db.MedicineType.FindAsync(id);

            if(MedicineType ==null)
            {
                return View();
            }
            _db.MedicineType.Remove(MedicineType);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var MedicineType = await _db.MedicineType.FindAsync(id);
            if (MedicineType == null)
            {
                return NotFound();
            }

            return View(MedicineType);
        }

    }
}