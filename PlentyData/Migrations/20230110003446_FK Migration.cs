using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlentyData.Migrations
{
    public partial class FKMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Entidade_EnderecoEntidadeId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Entidade_TelefoneEntidadeId",
                table: "Telefone");

            migrationBuilder.RenameColumn(
                name: "TelefoneEntidadeId",
                table: "Telefone",
                newName: "EntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_TelefoneEntidadeId",
                table: "Telefone",
                newName: "IX_Telefone_EntidadeId");

            migrationBuilder.RenameColumn(
                name: "EnderecoEntidadeId",
                table: "Endereco",
                newName: "EntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_EnderecoEntidadeId",
                table: "Endereco",
                newName: "IX_Endereco_EntidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Entidade_EntidadeId",
                table: "Endereco",
                column: "EntidadeId",
                principalTable: "Entidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Entidade_EntidadeId",
                table: "Telefone",
                column: "EntidadeId",
                principalTable: "Entidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Entidade_EntidadeId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Entidade_EntidadeId",
                table: "Telefone");

            migrationBuilder.RenameColumn(
                name: "EntidadeId",
                table: "Telefone",
                newName: "TelefoneEntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_EntidadeId",
                table: "Telefone",
                newName: "IX_Telefone_TelefoneEntidadeId");

            migrationBuilder.RenameColumn(
                name: "EntidadeId",
                table: "Endereco",
                newName: "EnderecoEntidadeId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_EntidadeId",
                table: "Endereco",
                newName: "IX_Endereco_EnderecoEntidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Entidade_EnderecoEntidadeId",
                table: "Endereco",
                column: "EnderecoEntidadeId",
                principalTable: "Entidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Entidade_TelefoneEntidadeId",
                table: "Telefone",
                column: "TelefoneEntidadeId",
                principalTable: "Entidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
