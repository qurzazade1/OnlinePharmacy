using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Models;

namespace OnlinePharmacy.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }



        public DbSet<MedicineType> MedicineType { get; set; }
        public DbSet<MedicineSubtype> MedicineSubtype { get; set; }

        public DbSet<DiscountCode> DiscountCode { get; set; }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Medicine> Medicine { get; set; }

        public DbSet<CustomerShoppingCart> CustomerShoppingCart { get; set; }

        public DbSet<CustomerCustomerOrderDetails> CustomerOrderDetails { get; set; }
        public DbSet<CustomerOrderHeader> CustomerOrderHeader { get; set; }








    }
}
