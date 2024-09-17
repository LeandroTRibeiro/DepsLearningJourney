using System.ComponentModel.DataAnnotations.Schema;
using GetProducts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



namespace GetProducts.DB;

public class Context : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        
        if (string.IsNullOrEmpty(connectionString))
        {
            throw new Exception("The ConnectionString is null or empty. Please check your .env file.");
        }
        
        optionsBuilder.UseNpgsql(connectionString);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Date)
            .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}