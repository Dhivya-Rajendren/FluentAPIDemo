using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FluentAPIDemo.Models
{
    public class BookStoreDbContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //   base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDb;database=lms_db;integrated security=true");
            
            //optionsBuilder.LogTo(Console.WriteLine, LogLevel.Information);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 3 types - Model configuration, entity configuration , property configuration

            modelBuilder.HasDefaultSchema("Lms");// Applied for the database.

            modelBuilder.Entity<Book>().ToTable("tbl_Books").HasKey(i=>i.BookCode);
           
            modelBuilder.Entity<Supplier>().ToTable("tbl_Suppliers");
            modelBuilder.Entity<Supplier>().Property(t => t.IsActive).HasDefaultValue(1);
            modelBuilder.Entity<Supplier>().HasQueryFilter(t => t.IsActive==1);// global query filter 
                
            //    modelBuilder.Entity<Book>().HasKey(i => i.BookCode);

            modelBuilder.Entity<Book>().Property(c => c.BookCode).HasColumnType("Char").HasMaxLength(20).HasColumnName("Book_code");
            modelBuilder.Entity<Supplier>().HasKey(c => c.SupplierId);
           


                
                }
    }
}
