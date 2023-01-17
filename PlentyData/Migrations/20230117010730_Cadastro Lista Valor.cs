using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlentyData.Migrations
{
    public partial class CadastroListaValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empresa_ProdutoListaValor_ProdutoListaValorid",
                table: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Empresa_ProdutoListaValorid",
                table: "Empresa");

            migrationBuilder.DropColumn(
                name: "ProdutoListaValorid",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "ProdutoListaValor",
                newName: "Nome");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoValorId",
                table: "ProdutoListaValor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoListaValor_ProdutoValorId",
                table: "ProdutoListaValor",
                column: "ProdutoValorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProdutoListaValor_ProdutoValor_ProdutoValorId",
                table: "ProdutoListaValor",
                column: "ProdutoValorId",
                principalTable: "ProdutoValor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProdutoListaValor_ProdutoValor_ProdutoValorId",
                table: "ProdutoListaValor");

            migrationBuilder.DropIndex(
                name: "IX_ProdutoListaValor_ProdutoValorId",
                table: "ProdutoListaValor");

            migrationBuilder.DropColumn(
                name: "ProdutoValorId",
                table: "ProdutoListaValor");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "ProdutoListaValor",
                newName: "nome");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoListaValorid",
                table: "Empresa",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_ProdutoListaValorid",
                table: "Empresa",
                column: "ProdutoListaValorid");

            migrationBuilder.AddForeignKey(
                name: "FK_Empresa_ProdutoListaValor_ProdutoListaValorid",
                table: "Empresa",
                column: "ProdutoListaValorid",
                principalTable: "ProdutoListaValor",
                principalColumn: "id");
        }
    }
}
