using ClothBazar.Entities;
using System.Data.Entity;

namespace ClothBazar.Database
{
    public class CBContext : DbContext
    {
        public CBContext() : base("ClothBazarConnection")
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
                .ToTable("Categories", "dbo");
            modelBuilder.Entity<Product>()
                .ToTable("Products", "dbo");
        }

    }
}
