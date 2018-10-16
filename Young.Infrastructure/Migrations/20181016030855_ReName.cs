using Microsoft.EntityFrameworkCore.Migrations;

namespace Young.Infrastructure.Migrations
{
    public partial class ReName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BorrowRecord_Reader_ReaderId",
                table: "BorrowRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reader",
                table: "Reader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BorrowRecord",
                table: "BorrowRecord");

            migrationBuilder.RenameTable(
                name: "Reader",
                newName: "reader");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "book");

            migrationBuilder.RenameTable(
                name: "BorrowRecord",
                newName: "borrow_record");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "reader",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "reader",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "reader",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "book",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "book",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "book",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "book",
                newName: "author");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "book",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PubDate",
                table: "book",
                newName: "pub_date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "borrow_record",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ReturnDate",
                table: "borrow_record",
                newName: "return_date");

            migrationBuilder.RenameColumn(
                name: "ReaderId",
                table: "borrow_record",
                newName: "reader_id");

            migrationBuilder.RenameColumn(
                name: "BorrowDays",
                table: "borrow_record",
                newName: "borrow_days");

            migrationBuilder.RenameColumn(
                name: "BorrowDate",
                table: "borrow_record",
                newName: "borrow_date");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "borrow_record",
                newName: "book_id");

            migrationBuilder.RenameIndex(
                name: "IX_BorrowRecord_ReaderId",
                table: "borrow_record",
                newName: "ix_borrow_record_reader_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_reader",
                table: "reader",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_book",
                table: "book",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_borrow_record",
                table: "borrow_record",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_borrow_record_reader_reader_id",
                table: "borrow_record",
                column: "reader_id",
                principalTable: "reader",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_borrow_record_reader_reader_id",
                table: "borrow_record");

            migrationBuilder.DropPrimaryKey(
                name: "pk_reader",
                table: "reader");

            migrationBuilder.DropPrimaryKey(
                name: "pk_book",
                table: "book");

            migrationBuilder.DropPrimaryKey(
                name: "pk_borrow_record",
                table: "borrow_record");

            migrationBuilder.RenameTable(
                name: "reader",
                newName: "Reader");

            migrationBuilder.RenameTable(
                name: "book",
                newName: "Book");

            migrationBuilder.RenameTable(
                name: "borrow_record",
                newName: "BorrowRecord");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Reader",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Reader",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Reader",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Book",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Book",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Book",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "author",
                table: "Book",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Book",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "pub_date",
                table: "Book",
                newName: "PubDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "BorrowRecord",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "return_date",
                table: "BorrowRecord",
                newName: "ReturnDate");

            migrationBuilder.RenameColumn(
                name: "reader_id",
                table: "BorrowRecord",
                newName: "ReaderId");

            migrationBuilder.RenameColumn(
                name: "borrow_days",
                table: "BorrowRecord",
                newName: "BorrowDays");

            migrationBuilder.RenameColumn(
                name: "borrow_date",
                table: "BorrowRecord",
                newName: "BorrowDate");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "BorrowRecord",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "ix_borrow_record_reader_id",
                table: "BorrowRecord",
                newName: "IX_BorrowRecord_ReaderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reader",
                table: "Reader",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BorrowRecord",
                table: "BorrowRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BorrowRecord_Reader_ReaderId",
                table: "BorrowRecord",
                column: "ReaderId",
                principalTable: "Reader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
