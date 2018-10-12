using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;

namespace Young.Infrastructure
{
    public class AppDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Reader> Readers { get; set; }

        public DbSet<BorrowRecord> BorrowRecords { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable("Book").HasKey(b => b.Id);
            modelBuilder.Entity<Book>().Property(b => b.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Book>().Property(b => b.Author).HasMaxLength(40).IsRequired();
            modelBuilder.Entity<Book>().Property(b => b.Price).IsRequired();

            modelBuilder.Entity<Reader>().ToTable("Reader").HasKey(r => r.Id);
            modelBuilder.Entity<Reader>().Property(b => b.Id).ValueGeneratedOnAdd();

            modelBuilder.Entity<BorrowRecord>().ToTable("BorrowRecord").HasKey(b => b.Id);
            modelBuilder.Entity<BorrowRecord>().Property(b => b.Id).ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
