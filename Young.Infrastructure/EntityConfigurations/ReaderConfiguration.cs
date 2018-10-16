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
            builder.Property(b => b.Id).ValueGeneratedOnAdd();
        }
    }
}
