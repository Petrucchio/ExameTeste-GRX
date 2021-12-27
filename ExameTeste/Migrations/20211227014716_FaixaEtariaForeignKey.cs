using Microsoft.EntityFrameworkCore.Migrations;

namespace ExameTeste.Migrations
{
    public partial class FaixaEtariaForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_FaixaEtaria_FaixaEtariaId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<int>(
                name: "FaixaEtariaId",
                table: "Pessoa",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_FaixaEtaria_FaixaEtariaId",
                table: "Pessoa",
                column: "FaixaEtariaId",
                principalTable: "FaixaEtaria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pessoa_FaixaEtaria_FaixaEtariaId",
                table: "Pessoa");

            migrationBuilder.AlterColumn<int>(
                name: "FaixaEtariaId",
                table: "Pessoa",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Pessoa_FaixaEtaria_FaixaEtariaId",
                table: "Pessoa",
                column: "FaixaEtariaId",
                principalTable: "FaixaEtaria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
