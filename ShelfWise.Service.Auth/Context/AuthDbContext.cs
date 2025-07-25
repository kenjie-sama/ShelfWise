using Microsoft.EntityFrameworkCore;
using ShelfWise.Service.Auth.Models.Entities;

namespace ShelfWise.Service.Auth.Context
{
  public class AuthDbContext : DbContext
  {
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<Person> People { get; set; }

    public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<Account>()
        .Ignore(c => c.EmailConfirmed)
        .Ignore(c => c.PhoneNumber)
        .Ignore(c => c.PhoneNumberConfirmed)
        .Ignore(c => c.TwoFactorEnabled)
        .Ignore(c => c.LockoutEnd)
        .Ignore(c => c.AccessFailedCount)
        .Ignore(c => c.AccessFailedCount)
        .Ignore(c => c.SecurityStamp)
        .Ignore(c => c.ConcurrencyStamp)
        .Ignore(c => c.LockoutEnabled)
        .Property(u => u.Id)
           .HasMaxLength(250);
    }
  }
}
