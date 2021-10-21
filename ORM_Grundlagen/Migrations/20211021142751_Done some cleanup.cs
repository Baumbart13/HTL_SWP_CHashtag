using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace ORM_Grundlagen.Migrations
{
    public partial class Donesomecleanup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles2",
                columns: table => new
                {
                    Article2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Articlename = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles2", x => x.Article2Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices2",
                columns: table => new
                {
                    Invoice2Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices2", x => x.Invoice2Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices2Articles2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Invoice2Id = table.Column<int>(type: "int", nullable: true),
                    Article2Id = table.Column<int>(type: "int", nullable: true),
                    EndPrice = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices2Articles2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices2Articles2s_Articles2_Article2Id",
                        column: x => x.Article2Id,
                        principalTable: "Articles2",
                        principalColumn: "Article2Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices2Articles2s_Invoices2_Invoice2Id",
                        column: x => x.Invoice2Id,
                        principalTable: "Invoices2",
                        principalColumn: "Invoice2Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices2Articles2s_Article2Id",
                table: "Invoices2Articles2s",
                column: "Article2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices2Articles2s_Invoice2Id",
                table: "Invoices2Articles2s",
                column: "Invoice2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices2Articles2s");

            migrationBuilder.DropTable(
                name: "Articles2");

            migrationBuilder.DropTable(
                name: "Invoices2");
        }
    }
}
