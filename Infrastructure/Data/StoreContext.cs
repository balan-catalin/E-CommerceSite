using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base((DbContextOptions) options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}
