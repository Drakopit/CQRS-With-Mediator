using CQRS.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    }
}
