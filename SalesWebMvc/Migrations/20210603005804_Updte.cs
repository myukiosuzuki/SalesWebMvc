using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class Updte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecort_Seller_SellerId",
                table: "SalesRecort");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecort",
                table: "SalesRecort");

            migrationBuilder.RenameTable(
                name: "SalesRecort",
                newName: "SalesRecord");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecort_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SalesRecord",
                table: "SalesRecord");

            migrationBuilder.RenameTable(
                name: "SalesRecord",
                newName: "SalesRecort");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecort",
                newName: "IX_SalesRecort_SellerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SalesRecort",
                table: "SalesRecort",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecort_Seller_SellerId",
                table: "SalesRecort",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
