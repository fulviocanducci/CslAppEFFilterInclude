using CslAppEFFilterInclude.Models;
using CslAppEFFilterInclude.Models.Maps;
using Microsoft.EntityFrameworkCore;

namespace CslAppEFFilterInclude.Data
{
    public class DatabaseSource : DbContext
    {
        public DatabaseSource(DbContextOptions<DatabaseSource> options)
            :base(options)
        {
        }

        public DbSet<Sales> Sales { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SaleMap());
            modelBuilder.ApplyConfiguration(new ItemMap());
        }
    }
}
