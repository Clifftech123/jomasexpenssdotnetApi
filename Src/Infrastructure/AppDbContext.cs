

using jomasexpenssdotnetApi.Src.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace jomasexpenssdotnetApi.Src.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSets for your entities
        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Expense>(
                           entity =>
                           {
                               entity.HasKey(e => e.Id);
                               entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
                               entity.Property(e => e.Description).HasMaxLength(500);
                               entity.Property(e => e.CreatedAt).HasDefaultValueSql("GETUTCDATE()");
                               entity.Property(e => e.UpdatedAt).HasDefaultValueSql("GETUTCDATE()");

                               entity.HasOne(e => e.Category)
                                   .WithMany(c => c.Expenses)
                                   .HasForeignKey(e => e.CategoryId)
                                   .OnDelete(DeleteBehavior.Cascade);

                               entity.HasOne(e => e.User)
                                   .WithMany(u => u.Expenses)
                                   .HasForeignKey(e => e.UserId)
                                   .OnDelete(DeleteBehavior.Cascade);
                           }
                       );

                          modelBuilder.Entity<Category>(
                           entity =>
                           {
                               entity.HasKey(c => c.Id);
                               entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
                               entity.Property(c => c.Description).HasMaxLength(500);
                           }
                       );

        }




    }
}