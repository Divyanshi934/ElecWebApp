using ElecWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace ElecWebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; } //Categories table will be created in DB

        //Seeding data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Tube", DisplayOrder = 5 },
                new Category { Id = 2, Name = "Bulb", DisplayOrder = 10 },
                new Category { Id = 3, Name = "Fan", DisplayOrder = 20 }
                );
        }
    }
}
