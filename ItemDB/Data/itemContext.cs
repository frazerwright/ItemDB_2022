using ItemDB.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemDB.Data
{
    public class itemContext : DbContext
    {
        public itemContext(DbContextOptions<itemContext> options) : base(options)
        {

        }
        public DbSet<item> Items { get; set; }
        public DbSet<order> Orders { get; set; }
        public DbSet<recipient> recipients { get; set; }

    }
}
