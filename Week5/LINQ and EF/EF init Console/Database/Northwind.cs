using Microsoft.EntityFrameworkCore;

namespace EF_DB_First;

public class Northwind: DbContext
{
    private string path = String.Empty;
    public DbSet<Product>? Products {get; set;}
    public DbSet<Category>? Categories {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        path = Path.Combine(Environment.CurrentDirectory, "Northwind.db");
        string connpath = $"Data Source={path}";
        optionsBuilder.UseSqlite(connpath);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
                    .Property(c => c.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15);

        modelBuilder.Entity<Product>()
                    .HasKey(c => c.CategoryID);
        
        if (Database.ProviderName?.Contains("Sqlite") ?? false)
        {
            modelBuilder.Entity<Product>()
                        .Property(p => p.Cost)
                        .HasConversion<Double>();
        }
    }
}
