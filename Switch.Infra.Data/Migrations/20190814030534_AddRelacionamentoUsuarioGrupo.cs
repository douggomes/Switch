using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddRelacionamentoUsuarioGrupo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagems_Usuarios_UsuarioId",
                table: "Postagems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagems",
                table: "Postagems");

            migrationBuilder.RenameTable(
                name: "Postagems",
                newName: "Postagens");

            migrationBuilder.RenameIndex(
                name: "IX_Postagems_UsuarioId",
                table: "Postagens",
                newName: "IX_Postagens_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagens",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Postagens",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(maxLength: 100, nullable: false),
                    UrlFoto = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioGrupo",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: false),
                    EhAdministrador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioGrupo", x => new { x.UsuarioId, x.GrupoId });
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupos_GrupoId",
                table: "Postagens");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Usuarios_UsuarioId",
                table: "Postagens");

            migrationBuilder.DropTable(
                name: "UsuarioGrupo");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Postagens",
                table: "Postagens");

            migrationBuilder.DropIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Postagens");

            migrationBuilder.RenameTable(
                name: "Postagens",
                newName: "Postagems");

            migrationBuilder.RenameIndex(
                name: "IX_Postagens_UsuarioId",
                table: "Postagems",
                newName: "IX_Postagems_UsuarioId");

            migrationBuilder.AlterColumn<string>(
                name: "Texto",
                table: "Postagems",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Postagems",
                table: "Postagems",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Postagems_Usuarios_UsuarioId",
                table: "Postagems",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
