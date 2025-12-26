using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer("Server=localhost;Database=EFCoreDemoDB;Trusted_Connection=True;TrustServerCertificate=True;")
            .LogTo(Console.WriteLine, LogLevel.Information);
    }
}
