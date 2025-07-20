using Microsoft.EntityFrameworkCore;
using taskcrud.Entities;

namespace taskcrud.DAL
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                        .Property(c => c.IsEnable)
                        .HasDefaultValue(true);

            modelBuilder.Entity<Category>()
                .Property(c => c.CreateDateTime)
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}