using AglixBackend.Domain.Entities;
using AglixBackend.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace AglixBackend.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

        public DbSet<Agile> Agile { get; set; }
        public DbSet<AgileImplementation> AgileImplementation { get; set; }
        public DbSet<AgileImplementationElement> AgileImplementationElement { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Agile>()
                .HasMany(a => a.Implementations)
                .WithOne(ai => ai.Agile)
                .HasForeignKey(ai => ai.AgileId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<AgileImplementation>()
                .HasMany(ai => ai.Elements)
                .WithOne(e => e.AgileImplementation)
                .HasForeignKey(e => e.AgileImplementationId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
