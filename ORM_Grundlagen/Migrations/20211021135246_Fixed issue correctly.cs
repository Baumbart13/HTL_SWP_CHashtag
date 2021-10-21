using Microsoft.EntityFrameworkCore.Migrations;

namespace ORM_Grundlagen.Migrations
{
    public partial class Fixedissuecorrectly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ArticleInvoice",
                columns: table => new
                {
                    ArticlesArticleId = table.Column<int>(type: "int", nullable: false),
                    InvoicesInvoiceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleInvoice", x => new { x.ArticlesArticleId, x.InvoicesInvoiceId });
                    table.ForeignKey(
                        name: "FK_ArticleInvoice_Articles_ArticlesArticleId",
                        column: x => x.ArticlesArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleInvoice_Invoices_InvoicesInvoiceId",
                        column: x => x.InvoicesInvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleInvoice_InvoicesInvoiceId",
                table: "ArticleInvoice",
                column: "InvoicesInvoiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleInvoice");

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
    }
}
