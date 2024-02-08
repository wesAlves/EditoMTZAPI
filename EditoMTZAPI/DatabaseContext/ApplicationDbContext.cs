using EditoMTZAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EditoMTZAPI.DatabaseContext;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public ApplicationDbContext()
    {
    }

    public virtual DbSet<Ebook> Ebooks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Ebook>().HasData(new Ebook() { EbookID = Guid.NewGuid(), EbookName = "One" });
        modelBuilder.Entity<Ebook>().HasData(new Ebook() { EbookID = Guid.NewGuid(), EbookName = "Two" });
    }
}