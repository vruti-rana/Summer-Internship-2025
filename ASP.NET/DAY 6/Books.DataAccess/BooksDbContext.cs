using Books.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

public class BooksDbContext : DbContext
{
    public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) { }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>().ToTable("books"); // Ensure this matches your actual table
    }
}
