using Microsoft.EntityFrameworkCore;
using WebAPI.DataAccess.Models;

namespace WebAPI.DataAccess
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Course> Courses { get; set; }

    }
}
