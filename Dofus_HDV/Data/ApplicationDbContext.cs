using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dofus_HDV.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Item> Items { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserID);
            entity.HasIndex(e => e.Username).IsUnique();
            entity.HasIndex(e => e.Email).IsUnique();
            entity.HasMany(e => e.Transactions)
                  .WithOne(t => t.User)
                  .HasForeignKey(t => t.UserID);
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryID);
            entity.HasIndex(e => e.CategoryName).IsUnique();
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.ItemID);
            entity.HasOne<Category>()
                  .WithMany()
                  .HasForeignKey(e => e.CategoryID);
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.HasKey(e => e.TransactionID);
            entity.HasOne(t => t.User)
                  .WithMany(u => u.Transactions)
                  .HasForeignKey(t => t.UserID);
            entity.HasOne(t => t.Item)
                  .WithMany()
                  .HasForeignKey(t => t.ItemID);
        });



    }

}
