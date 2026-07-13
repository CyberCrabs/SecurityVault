using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SecurityVault.Core.Entities;

namespace SecurityVault.Persistance.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext
{
    public DbSet<User> Users { get; set; } 
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<User>()
            .HasKey(u => u.Id);
    }
}