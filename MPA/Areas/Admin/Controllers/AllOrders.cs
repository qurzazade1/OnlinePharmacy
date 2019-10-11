using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlinePharmacy.Data;
using OnlinePharmacy.Models;
using OnlinePharmacy.Models.ViewModels;
using OnlinePharmacy.WebShopUtility;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlinePharmacy.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = SD.ManagerUser)]
    public class AllOrders:Controller
    {

        private ApplicationDbContext _db;
        private int PageSize = 8;
        public AllOrders(ApplicationDbContext db)
        {
            _db = db;
        }




        [Authorize]
        public async Task<IActionResult> AllOrdersHistory(int productPage = 1)
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);


            CustomerOrderListViewModel CustomerOrderListVM = new CustomerOrderListViewModel()
            {
                Orders = new List<CustomerOrderDetailsViewModel>()
            };



            //          List<CustomerOrderHeader> CustomerOrderHeaderList =  _db.CustomerOrderHeader.Include(o => o.ApplicationUser).Where(u => u.UserId == u.ApplicationUser.Id).ToList();
            List<CustomerOrderHeader> CustomerOrderHeaderList = new List<CustomerOrderHeader>();
              CustomerOrderHeaderList=  _db.CustomerOrderHeader.Include(o => o.ApplicationUser).Where(u => u.Status == SD.StatusReady|| u.Status == SD.StatusCompleted|| u.Status == SD.StatusCancelled || u.Status == SD.StatusSubmitted|| u.Status == SD.StatusInProcess).ToList();

            foreach (CustomerOrderHeader item in CustomerOrderHeaderList)
            {
                CustomerOrderDetailsViewModel individual = new CustomerOrderDetailsViewModel
                {
                    CustomerOrderHeader = item,
                    CustomerOrderDetails =  _db.CustomerOrderDetails.Where(o => o.OrderId == item.Id).ToList()
                };
                item.ApplicationUser = _db.ApplicationUser.Find(item.UserId);
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
                urlParam = "/Admin/AllOrders/AllOrdersHistory?productPage=:"
            };
            return View(CustomerOrderListVM);
        }

     
    }
}
