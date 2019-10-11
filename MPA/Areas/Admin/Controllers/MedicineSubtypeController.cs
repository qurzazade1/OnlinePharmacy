using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.Models.ViewModels;
using OnlinePharmacy.WebShopUtility;

namespace OnlinePharmacy.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.ManagerUser)]
    public class MedicineSubtypeController : Controller
    {
        private readonly ApplicationDbContext _db;

        [TempData]
        public string StatusMessage { get; set; }

        public MedicineSubtypeController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Get INDEX
        public async Task<IActionResult> Index()
        {
            var subCategories = await _db.MedicineSubtype.Include(s=>s.MedicineType).ToListAsync();
            return View(subCategories);
        }
   
        //GET - CREATE
        public async Task<IActionResult> Create()
        {
            MedicineTypeandMedicineSubtypeViewModel model = new MedicineTypeandMedicineSubtypeViewModel()
            {
                MedicineTypeList = await _db.MedicineType.ToListAsync(),
                MedicineSubtype = new Models.MedicineSubtype(),
                MedicineSubtypeList = await _db.MedicineSubtype.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
            };

            return View(model);
        }
        
   //POST - CREATE
   [HttpPost]
   [ValidateAntiForgeryToken]
   public async Task<IActionResult> Create(MedicineTypeandMedicineSubtypeViewModel model)
   {
       if(ModelState.IsValid)
       {
           var doesMedicineSubtypeExists = _db.MedicineSubtype.Include(s => s.MedicineType).Where(s => s.Name == model.MedicineSubtype.Name && s.MedicineType.Id == model.MedicineSubtype.MedicineTypeId);

           if(doesMedicineSubtypeExists.Count()>0)
           {
               //Error
               StatusMessage = "Error : Sub Type exists under " + doesMedicineSubtypeExists.First().MedicineType.Name + " Type. Please use another name.";
           }
           else
           {
               _db.MedicineSubtype.Add(model.MedicineSubtype);
               await _db.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
           }
       }
       MedicineTypeandMedicineSubtypeViewModel modelVM = new MedicineTypeandMedicineSubtypeViewModel()
       {
           MedicineTypeList = await _db.MedicineType.ToListAsync(),
           MedicineSubtype = model.MedicineSubtype,
           MedicineSubtypeList = await _db.MedicineSubtype.OrderBy(p => p.Name).Select(p => p.Name).ToListAsync(),
           StatusMessage = StatusMessage
       };
       return View(modelVM);
   }

   [ActionName("GetMedicineSubtype")]
   public async Task<IActionResult> GetMedicineSubtype(int id)
   {
       List<MedicineSubtype> subCategories = new List<MedicineSubtype>();

       subCategories = await (from MedicineSubtype in _db.MedicineSubtype
                        where MedicineSubtype.MedicineTypeId == id
                        select MedicineSubtype).ToListAsync();
       return Json(new SelectList(subCategories, "Id", "Name"));
   }
       // GetMedicineSubtype


   //GET - EDIT
   public async Task<IActionResult> Edit(int? id)
   {
       if(id==null)
       {
           return NotFound();
       }

       var MedicineSubtype = await _db.MedicineSubtype.SingleOrDefaultAsync(m => m.Id == id);

       if(MedicineSubtype==null)
       {
           return NotFound();
       }

       MedicineTypeandMedicineSubtypeViewModel model = new MedicineTypeandMedicineSubtypeViewModel()
       {
           MedicineTypeList = await _db.MedicineType.ToListAsync(),
           MedicineSubtype = MedicineSubtype,
           MedicineSubtypeList = await _db.MedicineSubtype.OrderBy(p => p.Name).Select(p => p.Name).Distinct().ToListAsync()
       };

       return View(model);
   }

   //POST - EDIT
   [HttpPost]
   [ValidateAntiForgeryToken]
   public async Task<IActionResult> Edit(MedicineTypeandMedicineSubtypeViewModel model)
   {
       if (ModelState.IsValid)
       {
           var doesMedicineSubtypeExists = _db.MedicineSubtype.Include(s => s.MedicineType).Where(s => s.Name == model.MedicineSubtype.Name && s.MedicineType.Id == model.MedicineSubtype.MedicineTypeId);

           if (doesMedicineSubtypeExists.Count() > 0)
           {
               //Error
               StatusMessage = "Error : Sub Type exists under " + doesMedicineSubtypeExists.First().MedicineType.Name + " Type. Please use another name.";
           }
           else
           {
               var subCatFromDb = await _db.MedicineSubtype.FindAsync(model.MedicineSubtype.Id);
               subCatFromDb.Name = model.MedicineSubtype.Name;

               await _db.SaveChangesAsync();
               return RedirectToAction(nameof(Index));
           }
       }
       MedicineTypeandMedicineSubtypeViewModel modelVM = new MedicineTypeandMedicineSubtypeViewModel()
       {
           MedicineTypeList = await _db.MedicineType.ToListAsync(),
           MedicineSubtype = model.MedicineSubtype,
           MedicineSubtypeList = await _db.MedicineSubtype.OrderBy(p => p.Name).Select(p => p.Name).ToListAsync(),
           StatusMessage = StatusMessage
       };
       //modelVM.MedicineSubtype.Id = id;
       return View(modelVM);
   }
        //GET Details
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var MedicineSubtype = await _db.MedicineSubtype.Include(s => s.MedicineType).SingleOrDefaultAsync(m => m.Id == id);
            if (MedicineSubtype == null)
            {
                return NotFound();
            }

            return View(MedicineSubtype);
        }

        //GET Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var MedicineSubtype = await _db.MedicineSubtype.Include(s => s.MedicineType).SingleOrDefaultAsync(m => m.Id == id);
            if (MedicineSubtype == null)
            {
                return NotFound();
            }

            return View(MedicineSubtype);
        }

        //POST Delete
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var MedicineSubtype = await _db.MedicineSubtype.SingleOrDefaultAsync(m => m.Id == id);
            _db.MedicineSubtype.Remove(MedicineSubtype);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


    }
}