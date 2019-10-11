using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.Models.ViewModels;
using OnlinePharmacy.WebShopUtility;

namespace OnlinePharmacy.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustomerOrderController : Controller
    {

        private ApplicationDbContext _db;
        private int PageSize = 2;
        public CustomerOrderController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> Confirm(int id)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            CustomerOrderDetailsViewModel CustomerOrderDetailsViewModel = new CustomerOrderDetailsViewModel()
            {
                CustomerOrderHeader = await _db.CustomerOrderHeader.Include(o => o.ApplicationUser).FirstOrDefaultAsync(o => o.Id == id && o.UserId == claim.Value),
                CustomerOrderDetails = await _db.CustomerOrderDetails.Where(o => o.OrderId == id).ToListAsync()
            };

            return View(CustomerOrderDetailsViewModel);
        }

    

        public IActionResult GetOrderStatus(int Id)
        {
            return PartialView("_OrderStatus", _db.CustomerOrderHeader.Where(m => m.Id == Id).FirstOrDefault().Status);

        }
        
        [Authorize]
        public async Task<IActionResult> OrderHistory(int productPage=1)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


            CustomerOrderListViewModel CustomerOrderListVM = new CustomerOrderListViewModel()
            {
                Orders = new List<CustomerOrderDetailsViewModel>()
            };

            

            List<CustomerOrderHeader> CustomerOrderHeaderList = await _db.CustomerOrderHeader.Include(o => o.ApplicationUser).Where(u => u.UserId == claim.Value).ToListAsync();

            foreach (CustomerOrderHeader item in CustomerOrderHeaderList)
            {
                CustomerOrderDetailsViewModel individual = new CustomerOrderDetailsViewModel
                {
                    CustomerOrderHeader = item,
                    CustomerOrderDetails = await _db.CustomerOrderDetails.Where(o => o.OrderId == item.Id).ToListAsync()
                };
                CustomerOrderListVM.Orders.Add(individual);
            }

            var count = CustomerOrderListVM.Orders.Count;

           CustomerOrderListVM.Orders = CustomerOrderListVM.Orders.OrderByDescending(p => p.CustomerOrderHeader.Id)
                                 .Skip((productPage - 1) * PageSize)
                                 .Take(PageSize).ToList();

            CustomerOrderListVM.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItem = count,
                urlParam = "/Customer/CustomerOrder/OrderHistory?productPage=:"
            };
            return View(CustomerOrderListVM);
        }
        





        [Authorize(Roles = SD.PharmacistUser + "," + SD.ManagerUser)]
        public async Task<IActionResult> PrepareOrder(int productPage = 1)
        {
           
            List<CustomerOrderDetailsViewModel> CustomerOrderDetailsVM = new List<CustomerOrderDetailsViewModel>();

            List<CustomerOrderHeader> CustomerOrderHeaderList = await _db.CustomerOrderHeader.Where(o=>o.Status==SD.StatusSubmitted || o.Status==SD.StatusInProcess).OrderByDescending(u=>u.PickUpTime).ToListAsync();
            

            foreach (CustomerOrderHeader item in CustomerOrderHeaderList)
            {
                CustomerOrderDetailsViewModel individual = new CustomerOrderDetailsViewModel
                {
                    CustomerOrderHeader = item,
                    CustomerOrderDetails = await _db.CustomerOrderDetails.Where(o => o.OrderId == item.Id).ToListAsync()
                };
                CustomerOrderDetailsVM.Add(individual);
            }

            

            return View(CustomerOrderDetailsVM.OrderBy(o=>o.CustomerOrderHeader.PickUpTime).ToList());
        }


        public async Task<IActionResult> GetCustomerOrderDetails(int Id)
        {
            CustomerOrderDetailsViewModel CustomerOrderDetailsViewModel = new CustomerOrderDetailsViewModel()
            {
                CustomerOrderHeader = await _db.CustomerOrderHeader.FirstOrDefaultAsync(m => m.Id == Id),
                CustomerOrderDetails = await _db.CustomerOrderDetails.Where(m => m.OrderId == Id).ToListAsync()
        };
            CustomerOrderDetailsViewModel.CustomerOrderHeader.ApplicationUser = await _db.ApplicationUser.FirstOrDefaultAsync(u => u.Id == CustomerOrderDetailsViewModel.CustomerOrderHeader.UserId);

            return PartialView("_IndividualCustomerOrderDetails", CustomerOrderDetailsViewModel);
        }

        [Authorize(Roles = SD.PharmacistUser + "," + SD.ManagerUser)]
        public async Task<IActionResult> OrderPrepare(int OrderId)
        {
            CustomerOrderHeader CustomerOrderHeader = await _db.CustomerOrderHeader.FindAsync(OrderId);
            CustomerOrderHeader.Status = SD.StatusInProcess;
            await _db.SaveChangesAsync();
            return RedirectToAction("PrepareOrder", "CustomerOrder");
        }


        [Authorize(Roles = SD.PharmacistUser + "," + SD.ManagerUser)]
        public async Task<IActionResult> OrderReady(int OrderId)
        {
            CustomerOrderHeader CustomerOrderHeader = await _db.CustomerOrderHeader.FindAsync(OrderId);
            CustomerOrderHeader.Status = SD.StatusReady;
            await _db.SaveChangesAsync();

            
            return RedirectToAction("PrepareOrder", "CustomerOrder");
        }


        [Authorize(Roles = SD.PharmacistUser + "," + SD.ManagerUser)]
        public async Task<IActionResult> OrderCancel(int OrderId)
        {
            CustomerOrderHeader CustomerOrderHeader = await _db.CustomerOrderHeader.FindAsync(OrderId);
            CustomerOrderHeader.Status = SD.StatusCancelled;
            await _db.SaveChangesAsync();
            return RedirectToAction("PrepareOrder", "CustomerOrder");
        }

        [Authorize]
        public async Task<IActionResult> OrderDelivery(int productPage = 1, string searchEmail = null, string searchPhone = null, string searchName = null)
        {
            
            CustomerOrderListViewModel CustomerOrderListVM = new CustomerOrderListViewModel()
            {
                Orders = new List<CustomerOrderDetailsViewModel>()
            };

            StringBuilder param = new StringBuilder();
            param.Append("/Customer/CustomerOrder/OrderDelivery?productPage=:");
            param.Append("&searchName=");
            if (searchName != null)
            {
                param.Append(searchName);
            }
            

            List<CustomerOrderHeader> CustomerOrderHeaderList = new List<CustomerOrderHeader>();
            if (searchName != null || searchEmail != null || searchPhone != null)
            {
                var user = new ApplicationUser();

                if (searchName != null)
                {
                    CustomerOrderHeaderList = await _db.CustomerOrderHeader.Include(o => o.ApplicationUser)
                                                .Where(u => u.PickupName.ToLower().Contains(searchName.ToLower()))
                                                .OrderByDescending(o => o.OrderDate).ToListAsync();
                }
              
            }
            else
            {
                CustomerOrderHeaderList = await _db.CustomerOrderHeader.Include(o => o.ApplicationUser).Where(u => u.Status == SD.StatusReady).ToListAsync();
            }

            foreach (CustomerOrderHeader item in CustomerOrderHeaderList)
            {
                CustomerOrderDetailsViewModel individual = new CustomerOrderDetailsViewModel
                {
                    CustomerOrderHeader = item,
                    CustomerOrderDetails = await _db.CustomerOrderDetails.Where(o => o.OrderId == item.Id).ToListAsync()
                };
                CustomerOrderListVM.Orders.Add(individual);
            }



            var count = CustomerOrderListVM.Orders.Count;
            CustomerOrderListVM.Orders = CustomerOrderListVM.Orders.OrderByDescending(p => p.CustomerOrderHeader.Id)
                                 .Skip((productPage - 1) * PageSize)
                                 .Take(PageSize).ToList();

            CustomerOrderListVM.PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItem = count,
                urlParam = param.ToString()
            };

            return View(CustomerOrderListVM);
        }


        [Authorize(Roles = SD.PostmanUser + "," + SD.ManagerUser)]
        [HttpPost]
        [ActionName("OrderDelivery")]
        public async Task<IActionResult> OrderDeliveryPost(int orderId)
        {
            CustomerOrderHeader CustomerOrderHeader = await _db.CustomerOrderHeader.FindAsync(orderId);
            CustomerOrderHeader.Status = SD.StatusCompleted;
            await _db.SaveChangesAsync();
            return RedirectToAction("OrderDelivery", "CustomerOrder");
        }


    }
}