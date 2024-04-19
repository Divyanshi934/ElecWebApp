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
    }
}
