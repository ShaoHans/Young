using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;

namespace Young.Infrastructure.EntityConfigurations
{
    public class BorrowRecordConfiguration : IEntityTypeConfiguration<BorrowRecord>
    {
        public void Configure(EntityTypeBuilder<BorrowRecord> builder)
        {
            builder.ToTable("BorrowRecord").HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
        }
    }
}
