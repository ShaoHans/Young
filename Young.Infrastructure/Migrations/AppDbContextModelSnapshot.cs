﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Young.Infrastructure;

namespace Young.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Young.Domain.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnName("author")
                        .HasMaxLength(40);

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasColumnName("price");

                    b.Property<DateTime>("PubDate")
                        .HasColumnName("pub_date");

                    b.Property<int>("Status")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("pk_book");

                    b.ToTable("book");
                });

            modelBuilder.Entity("Young.Domain.Models.BorrowRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<int>("BookId")
                        .HasColumnName("book_id");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnName("borrow_date");

                    b.Property<int>("BorrowDays")
                        .HasColumnName("borrow_days");

                    b.Property<int>("ReaderId")
                        .HasColumnName("reader_id");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnName("return_date");

                    b.HasKey("Id")
                        .HasName("pk_borrow_record");

                    b.HasIndex("ReaderId")
                        .HasName("ix_borrow_record_reader_id");

                    b.ToTable("borrow_record");
                });

            modelBuilder.Entity("Young.Domain.Models.Reader", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_reader");

                    b.ToTable("reader");
                });

            modelBuilder.Entity("Young.Domain.Models.BorrowRecord", b =>
                {
                    b.HasOne("Young.Domain.Models.Reader")
                        .WithMany("BorrowRecords")
                        .HasForeignKey("ReaderId")
                        .HasConstraintName("fk_borrow_record_reader_reader_id")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
