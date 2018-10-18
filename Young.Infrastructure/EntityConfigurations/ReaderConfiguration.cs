using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Young.Domain.Models;

namespace Young.Infrastructure.EntityConfigurations
{
    public class ReaderConfiguration : IEntityTypeConfiguration<Reader>
    {
        public void Configure(EntityTypeBuilder<Reader> builder)
        {
            builder.ToTable("Reader").HasKey(r => r.Id);
            builder.Property(b => b.Id).HasColumnName("ReaderId").ValueGeneratedOnAdd();
            /* 迁移的时候有bug
            builder.OwnsOne(b => b.Local).Property(l => l.ProvinceName).HasColumnType("varchar(30)");
            builder.OwnsOne(b => b.Local).Property(l => l.CityName).HasColumnType("varchar(30)");
            builder.OwnsOne(b => b.Nation).Property(l => l.ProvinceName).HasColumnType("varchar(30)");
            builder.OwnsOne(b => b.Nation).Property(l => l.CityName).HasColumnType("varchar(30)");
            */
        }
    }
}
