

using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> Options) : base(Options)
        {

        }
          public DbSet <Category>Categories { get; set; }
          public DbSet <Product>Products { get; set; }
    }

    
}
