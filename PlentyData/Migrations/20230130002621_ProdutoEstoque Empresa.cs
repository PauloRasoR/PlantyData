using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlentyData.Migrations
{
    public partial class ProdutoEstoqueEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "ProdutoEstoque",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoEstoque_EmpresaId",
                table: "ProdutoEstoque",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoEstoque_Empresa_EmpresaId",
                table: "ProdutoEstoque",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoEstoque_Empresa_EmpresaId",
                table: "ProdutoEstoque");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoEstoque_EmpresaId",
                table: "ProdutoEstoque");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "ProdutoEstoque");
        }
    }
}
