using BrandOneCodingSession.Entities;
using Microsoft.EntityFrameworkCore;

namespace BrandOneCodingSession.Infrasatructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
