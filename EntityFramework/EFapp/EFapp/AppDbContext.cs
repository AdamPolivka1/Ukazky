using EFapp.Entity;
using Microsoft.EntityFrameworkCore;

namespace EFapp
{
    class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=db.db");
        }
    }
}
