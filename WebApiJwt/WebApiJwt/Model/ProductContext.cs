using Microsoft.EntityFrameworkCore;

namespace WebApiJwt.Model
{
    public class ProductContext:DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=productsdb;Username=postgres;Password=1");
        }



    }
 
}
