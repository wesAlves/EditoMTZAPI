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

        modelBuilder.Entity<Ebook>().HasData(new Ebook()
        {
            Id = Guid.Parse("AFEC3F04-C005-40BA-94AE-5D128C0600FC"), Title = "One", Description = "", SubTitle = "",
            Language = "", Subject = ""
        });
        modelBuilder.Entity<Ebook>().HasData(new Ebook()
        {
            Id = Guid.Parse("EB13D5C2-F370-49E9-8FB7-D605A196422C"), Title = "Two", Description = "", SubTitle = "",
            Language = "", Subject = ""
        });
    }

    public DbSet<Template> Template { get; set; } = default!;
}