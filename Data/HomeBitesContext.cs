using HomeBites.Models;
using HomeBites.Models;
using Microsoft.EntityFrameworkCore;
namespace HomeBites.Data
{
   

    public class HomeBitesContext : DbContext
    {
        public HomeBitesContext(DbContextOptions<HomeBitesContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
    }

}
