using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team
{
    /// <summary>
    /// Класс для работы с базой данных курсов
    /// </summary>
    public class CoursesContext : DbContext
    {
        /// <summary>
        /// Таблица с курсами в базе данных
        /// </summary>
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