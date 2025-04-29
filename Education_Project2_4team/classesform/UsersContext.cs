using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Reflection.Emit;
using System.Data.SQLite;
using Education_Project2_4team;
using Microsoft.EntityFrameworkCore;


namespace Education_Project2_4team
{
    //public class UsersContext:DbContext
    //{
    //    public DbSet<User> Users { get; set; }
    //    public UsersContext() : base("DefaultConnection") { }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlite("Data Source=UserDatabase.db");
    //    }
    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<User>()
    //            .ToTable("Users")
    //            .HasKey(u => u.Id);
    //        modelBuilder.Entity<User>();
    //    }
    //}
}
