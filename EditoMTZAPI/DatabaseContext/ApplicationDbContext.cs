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
        
    }


    public DbSet<Template> Template { get; set; }


    public DbSet<Chapter> Chapters { get; set; }
}