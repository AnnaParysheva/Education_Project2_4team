using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team
{
    public class CoursesContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=UserDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>()
                .ToTable("Courses")
                .HasKey(c => c.IDCourses); 
        }
    }
}
