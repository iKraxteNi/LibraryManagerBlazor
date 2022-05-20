using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagerBlazor.Server.Migrations
{
    public partial class add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Customer_CustomerId",
                table: "Book");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Book",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "CustomerName",
                table: "Book",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Customer_CustomerId",
                table: "Book",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Customer_CustomerId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "CustomerName",
                table: "Book");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Book",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Customer_CustomerId",
                table: "Book",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
