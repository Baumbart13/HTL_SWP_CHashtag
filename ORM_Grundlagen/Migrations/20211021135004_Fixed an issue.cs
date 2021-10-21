using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM_Grundlagen.Migrations
{
    public partial class Fixedanissue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Articles_InvoiceId",
                table: "Articles",
                column: "InvoiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Invoices_InvoiceId",
                table: "Articles",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "InvoiceId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Invoices_InvoiceId",
                table: "Articles");

            migrationBuilder.DropIndex(
                name: "IX_Articles_InvoiceId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Articles");
        }
    }
}
