using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education_Project2_4team
{
    public class FavouritesContext : DbContext
    {
        public DbSet<Favourites> Favourites { get; set; }
        public DbSet<Users> Users { get; set; }
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
