using Microsoft.EntityFrameworkCore.Migrations;

namespace Switch.Infra.Data.Migrations
{
    public partial class AddDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupo_Grupos_GrupoId",
                table: "UsuarioGrupo");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                table: "UsuarioGrupo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo");

            migrationBuilder.RenameTable(
                name: "UsuarioGrupo",
                newName: "UsuarioGrupos");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuarioGrupos",
                newName: "IX_UsuarioGrupos_GrupoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupos",
                table: "UsuarioGrupos",
                columns: new[] { "UsuarioId", "GrupoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GrupoId",
                table: "UsuarioGrupos",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupos_Usuarios_UsuarioId",
                table: "UsuarioGrupos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Grupos_GrupoId",
                table: "UsuarioGrupos");

            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioGrupos_Usuarios_UsuarioId",
                table: "UsuarioGrupos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioGrupos",
                table: "UsuarioGrupos");

            migrationBuilder.RenameTable(
                name: "UsuarioGrupos",
                newName: "UsuarioGrupo");

            migrationBuilder.RenameIndex(
                name: "IX_UsuarioGrupos_GrupoId",
                table: "UsuarioGrupo",
                newName: "IX_UsuarioGrupo_GrupoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioGrupo",
                table: "UsuarioGrupo",
                columns: new[] { "UsuarioId", "GrupoId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupo_Grupos_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                table: "UsuarioGrupo",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
