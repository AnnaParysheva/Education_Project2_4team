using Microsoft.EntityFrameworkCore;


namespace Education_Project2_4team
{
    /// <summary>
    /// Контекст базы данных для работы с пользователями
    /// </summary>
    public class UsersContext : DbContext
    {
        /// <summary>
        /// Таблица пользователей системы
        /// </summary>
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=UserDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Id).HasColumnType("TEXT");
            });
        }
    }
}