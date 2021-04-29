
using MahaleSystem.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace MahaleSystem.Models
{
    public class ManahelContext:IdentityDbContext<CustomIdentityuser,CustomIdentityRole,string>
    {
        public ManahelContext(DbContextOptions options ):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Initailizer();
        }
        public DbSet<ImagesManahel> ImagesManahels { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Khalias> khaliases { get; set; }
        public DbSet<Manahel> Manahels { get; set; }
        public DbSet<Queue> Queues { get; set; }
        public DbSet<ImagesProduct> ImagesProducts { get; set; }
        public DbSet<UsersManhals> UsersManhals { get; set; }
    }
    
}
