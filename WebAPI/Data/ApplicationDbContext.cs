using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Car> Cars { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.UseCollation("utf8_general_ci")
                .HasCharSet("utf8");


            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PRIMARY");
            });
        }
    }
}
