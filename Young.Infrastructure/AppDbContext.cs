using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;
using Young.Infrastructure.EntityConfigurations;

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
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new ReaderConfiguration());
            modelBuilder.ApplyConfiguration(new BorrowRecordConfiguration());

            DatabaseMeteDataReName(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// 如果是使用PostgreSql，则使用snake_case命名法
        /// </summary>
        /// <param name="modelBuilder"></param>
        private void DatabaseMeteDataReName(ModelBuilder modelBuilder)
        {
            // 参考文章
            // https://andrewlock.net/customising-asp-net-core-identity-ef-core-naming-conventions-for-postgresql/

            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                // Replace table names
                entity.Relational().TableName = entity.Relational().TableName.ToSnakeCase();

                // Replace column names            
                foreach (var property in entity.GetProperties())
                {
                    property.Relational().ColumnName = property.Name.ToSnakeCase();
                }

                foreach (var key in entity.GetKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToSnakeCase();
                }

                foreach (var key in entity.GetForeignKeys())
                {
                    key.Relational().Name = key.Relational().Name.ToSnakeCase();
                }

                foreach (var index in entity.GetIndexes())
                {
                    index.Relational().Name = index.Relational().Name.ToSnakeCase();
                }
            }
        }
    }
}
