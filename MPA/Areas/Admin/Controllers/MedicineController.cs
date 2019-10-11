using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.Models.ViewModels;
using OnlinePharmacy.WebShopUtility;


using System.Web;
namespace OnlinePharmacy.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.ManagerUser)]
    public class MedicineController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;

        [BindProperty]
        public MedicineViewModel MedicineVM { get; set; }

        public MedicineController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            MedicineVM = new MedicineViewModel()
            {
                MedicineType = _db.MedicineType,
                Medicine = new Models.Medicine()
            };
        }

        public async Task<IActionResult> Index()
        {
            var Medicines = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).ToListAsync();
            return View(Medicines);
        }

        //GET - CREATE
        public IActionResult Create()
        {
            return View(MedicineVM);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreatePOST()
        {
            MedicineVM.Medicine.MedicineSubtypeId = Convert.ToInt32(Request.Form["MedicineSubtypeId"].ToString());

            if (!ModelState.IsValid)
            {
                return View(MedicineVM);
            }

            _db.Medicine.Add(MedicineVM.Medicine);
            await _db.SaveChangesAsync();

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;
          //  var files = HttpContext.Request.Form.Files[0];
            var MedicineFromDb = await _db.Medicine.FindAsync(MedicineVM.Medicine.Id);

              if (files.Count > 0)
            //if(files !=null)
            {
                //files has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension = Path.GetExtension(files[0].FileName);
            //    var extension = Path.GetExtension(files.FileName);

                using (var filesStream = new FileStream(Path.Combine(uploads, MedicineVM.Medicine.Id + extension), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                    //files.CopyTo(filesStream);
                }
                MedicineFromDb.Image = @"\images\" + MedicineVM.Medicine.Id + extension;
            }
            else
            {
                //no file was uploaded, so use default
                var uploads = Path.Combine(webRootPath, @"images\" + SD.DefaultMedicineImage);
                System.IO.File.Copy(uploads, webRootPath + @"\images\" + MedicineVM.Medicine.Id + ".png");
                MedicineFromDb.Image = @"\images\" + MedicineVM.Medicine.Id + ".png";
            }

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


        //GET : Delete Medicine
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MedicineVM.Medicine = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).SingleOrDefaultAsync(m => m.Id == id);

            if (MedicineVM.Medicine == null)
            {
                return NotFound();
            }

            return View(MedicineVM);
        }

        
        //GET - EDIT
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MedicineVM.Medicine = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).SingleOrDefaultAsync(m => m.Id == id);
            MedicineVM.Medicine.Description = SD.ConvertToRawHtml(MedicineVM.Medicine.Description);
            MedicineVM.MedicineSubtype = await _db.MedicineSubtype.Where(s => s.MedicineTypeId == MedicineVM.Medicine.MedicineTypeId).ToListAsync();

            if (MedicineVM.Medicine == null)
            {
                return NotFound();
            }
            return View(MedicineVM);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPOST(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            MedicineVM.Medicine.MedicineSubtypeId = Convert.ToInt32(Request.Form["MedicineSubtypeId"].ToString());

            if (!ModelState.IsValid)
            {
                MedicineVM.MedicineSubtype = await _db.MedicineSubtype.Where(s => s.MedicineTypeId == MedicineVM.Medicine.MedicineTypeId).ToListAsync();
                return View(MedicineVM);
            }

            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var MedicineFromDb = await _db.Medicine.FindAsync(MedicineVM.Medicine.Id);

            if (files.Count > 0)
            {
                //New Image has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension_new = Path.GetExtension(files[0].FileName);

                //Delete the original file
                var imagePath = Path.Combine(webRootPath, MedicineFromDb.Image.TrimStart('\\'));
                //     C: \Users\sadig\source\repos\OnlinePharmacy\MPA\wwwroot\images\2002.jpg

              //  var imagePath = Path.Combine(webRootPath, "images\\2002.jpg");
                //    

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                //we will upload the new file
                using (var filesStream = new FileStream(Path.Combine(uploads, MedicineVM.Medicine.Id + extension_new), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                MedicineFromDb.Image = @"\images\" + MedicineVM.Medicine.Id + extension_new;
            }

            MedicineFromDb.Name = MedicineVM.Medicine.Name;
            MedicineFromDb.Description = MedicineVM.Medicine.Description;
            MedicineFromDb.Price = MedicineVM.Medicine.Price;
            MedicineFromDb.Country = MedicineVM.Medicine.Country;
            MedicineFromDb.MedicineTypeId = MedicineVM.Medicine.MedicineTypeId;
            MedicineFromDb.MedicineSubtypeId = MedicineVM.Medicine.MedicineSubtypeId;

            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }




        [HttpPost, ActionName("EditMedcineImage")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditMedcineImage(int? myid)
        {
            if (myid == null)
            {
                return NotFound();
              //  id = 2002;
                //id =  Medicine.Id;
            }
     
            //Work on the image saving section

            string webRootPath = _hostingEnvironment.WebRootPath;
            var files = HttpContext.Request.Form.Files;

            var MedicineFromDb = await _db.Medicine.FindAsync(myid);

            if (files.Count > 0)
            {
                //New Image has been uploaded
                var uploads = Path.Combine(webRootPath, "images");
                var extension_new = Path.GetExtension(files[0].FileName);

                //Delete the original file
                var imagePath = Path.Combine(webRootPath, MedicineFromDb.Image.TrimStart('\\'));
                //     C: \Users\sadig\source\repos\OnlinePharmacy\MPA\wwwroot\images\2002.jpg

                //  var imagePath = Path.Combine(webRootPath, "images\\2002.jpg");
                //    

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                //we will upload the new file
                using (var filesStream = new FileStream(Path.Combine(uploads, myid + extension_new), FileMode.Create))
                {
                    files[0].CopyTo(filesStream);
                }
                MedicineFromDb.Image = @"\images\" +myid + extension_new;
            }

        
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }






















        //GET : Details Medicine
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MedicineVM.Medicine = await _db.Medicine.Include(m => m.MedicineType).Include(m => m.MedicineSubtype).SingleOrDefaultAsync(m => m.Id == id);

            if (MedicineVM.Medicine == null)
            {
                return NotFound();
            }

            return View(MedicineVM);
        }

        
        //POST Delete Medicine
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string webRootPath = _hostingEnvironment.WebRootPath;
            Medicine Medicine = await _db.Medicine.FindAsync(id);

            if (Medicine != null)
            {
                var imagePath = Path.Combine(webRootPath, Medicine.Image.TrimStart('\\'));

                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }
                _db.Medicine.Remove(Medicine);
                await _db.SaveChangesAsync();

            }

            return RedirectToAction(nameof(Index));
        }
    }
}