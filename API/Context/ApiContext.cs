using API.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace API.Context;

[ExcludeFromCodeCoverage]
public class ApiDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().ToTable("User");
        modelBuilder.Entity<User>().HasKey(x => x.UserId);
    }
}
