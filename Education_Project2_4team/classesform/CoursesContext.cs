using Microsoft.EntityFrameworkCore;
namespace Education_Project2_4team
{
    public class CoursesContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }

        public CoursesContext() { }

        public CoursesContext(DbContextOptions<CoursesContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=UserDatabase.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>()
                .ToTable("Courses")
                .HasKey(c => c.IDCourses);
        }
    }
}
