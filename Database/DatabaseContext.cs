using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TesttDeployApiWithEFcoreAndDocker.Database.Entities;

namespace TesttDeployApiWithEFcoreAndDocker.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Student> Student { get; set; } = null!;

        public DbSet<Book> Book { get; set; } = null!;

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
