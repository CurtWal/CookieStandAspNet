using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;
using CookieStandAspNet.Models;

namespace CookieStandAspNet.Data
{
    public class CookieStandDbContext : DbContext
    {
        public DbSet<CookieStand> CookieStand { get; set; }
        public CookieStandDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*int[] nums = { 17, 7, 7, 7, 15, 17, 7, 7, 12, 7, 7, 10, 17, 17 }; CookieStand Cookie1 = new CookieStand { Id = 336, location = "Barcelona", description = "", minimum_customers_per_hour = 3, maximum_customers_per_hour = 7, average_cookies_per_sale = 2.5m, owner = null, hourly_sales = nums };*/
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<CookieStand>().HasData(new CookieStand { Id = 336, location = "Barcelona", description = "", minimum_customers_per_hour = 3, maximum_customers_per_hour = 7, average_cookies_per_sale = 2.5m, owner = "NULL" });

        }
    }
}
