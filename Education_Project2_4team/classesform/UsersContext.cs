using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore.Sqlite;
using Education_Project2_4team;
using Microsoft.EntityFrameworkCore;


namespace Education_Project2_4team
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlite("Data Source=UserDatabase.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .ToTable("Users")
                .HasKey(u => u.Id);
        }
    }
}
