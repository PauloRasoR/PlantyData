using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlentyData.Migrations
{
    public partial class Produtocomestoque : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProdutoEstoque");

            migrationBuilder.AddColumn<decimal>(
                name: "EstoqueEntrada",
                table: "Produto",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EstoqueSaida",
                table: "Produto",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "EstoqueSaldo",
                table: "Produto",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstoqueEntrada",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EstoqueSaida",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EstoqueSaldo",
                table: "Produto");

            migrationBuilder.CreateTable(
                name: "ProdutoEstoque",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    EstoqueEntrada = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    EstoqueSaida = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    EstoqueSaldo = table.Column<decimal>(type: "decimal(65,30)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoEstoque", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutoEstoque_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoEstoque_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoEstoque_EmpresaId",
                table: "ProdutoEstoque",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoEstoque_ProdutoId",
                table: "ProdutoEstoque",
                column: "ProdutoId");
        }
    }
}
