using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Young.Infrastructure.Migrations
{
    public partial class BookAddGuid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "test_guid",
                table: "book",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "test_guid",
                table: "book");
        }
    }
}
