using Cardekho.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cardekho.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
        // database set to perform CRUD model
        public DbSet<Cardekho.Models.Inventory> Inventories { get; set; } = default;

        public DbSet<Company> Companies { get; set; } = default;

        public DbSet<Carinfo> Carinfos { get; set; } = default;

        public DbSet<Order> Orders { get; set; } = default;

        public DbSet<Orderdetail> OrderDetails { get; set; }
    }

}
