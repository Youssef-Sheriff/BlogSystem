using Microsoft.EntityFrameworkCore;

namespace Blog_System.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<BlogPost> Posts { get; set; } = null!;

}
