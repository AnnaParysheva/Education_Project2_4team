using Microsoft.EntityFrameworkCore;

namespace Education_Project2_4team
{
    /// <summary>
    /// Контекст базы данных для избранных курсов
    /// </summary>
    public class FavouritesContext : DbContext
    {
        /// <summary>
        /// Таблица избранных курсов
        /// </summary>
        public DbSet<Favourites> Favourites { get; set; }

        /// <summary>
        /// Таблица пользователей
        /// </summary>
        public DbSet<Users> Users { get; set; }

        /// <summary>
        /// Таблица курсов
        /// </summary>
        public DbSet<Courses> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=UserDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Favourites>()
                .ToTable("Favourites")
                .HasKey(f => f.ID);
            modelBuilder.Entity<Favourites>()
                .HasOne(f => f.User)
                .WithMany(u => u.Favourites)
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Favourites>()
                .HasOne(f => f.Course)
                .WithMany(c => c.Favourites)
                .HasForeignKey(f => f.IDCourses)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}