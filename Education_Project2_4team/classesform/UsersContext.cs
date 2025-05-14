using Microsoft.EntityFrameworkCore;


namespace Education_Project2_4team
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=UserDatabase.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .ToTable("Users")
                .HasKey(u => u.Id);
        }
    }
}
