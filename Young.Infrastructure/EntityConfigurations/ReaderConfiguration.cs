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
            /* 迁移的时候有bug*/
            //builder.OwnsOne(b => b.Local).Property(l => l.ProvinceName).HasColumnName("LocalProvinceName").HasColumnType("varchar(30)");
            //builder.OwnsOne(b => b.Local).Property(l => l.CityName).HasColumnName("LocalCityName").HasColumnType("varchar(30)");
            //builder.OwnsOne(b => b.Nation).Property(l => l.ProvinceName).HasColumnName("NationProvinceName").HasColumnType("varchar(30)");
            //builder.OwnsOne(b => b.Nation).Property(l => l.CityName).HasColumnName("NationCityName").HasColumnType("varchar(30)");

            //builder.OwnsOne(b => b.Local);
            builder.OwnsOne(b => b.Nation, nation =>
            {
                nation.Ignore(n => n.ProvinceCode);
            });
        }
    }
}
