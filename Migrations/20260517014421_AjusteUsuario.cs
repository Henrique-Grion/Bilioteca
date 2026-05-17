using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bilioteca.Migrations
{
    /// <inheritdoc />
    public partial class AjusteUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_UsuarioSistema_FuncionarioId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_UsuarioSistema_LeitorId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaEspera_UsuarioSistema_UsuarioId",
                table: "ListaEspera");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UsuarioSistema",
                table: "UsuarioSistema");

            migrationBuilder.RenameTable(
                name: "UsuarioSistema",
                newName: "Usuarios");

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Usuarios",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuarios_FuncionarioId",
                table: "Emprestimo",
                column: "FuncionarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuarios_LeitorId",
                table: "Emprestimo",
                column: "LeitorId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaEspera_Usuarios_UsuarioId",
                table: "ListaEspera",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuarios_FuncionarioId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuarios_LeitorId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaEspera_Usuarios_UsuarioId",
                table: "ListaEspera");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Usuarios",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Usuarios");

            migrationBuilder.RenameTable(
                name: "Usuarios",
                newName: "UsuarioSistema");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UsuarioSistema",
                table: "UsuarioSistema",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_UsuarioSistema_FuncionarioId",
                table: "Emprestimo",
                column: "FuncionarioId",
                principalTable: "UsuarioSistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_UsuarioSistema_LeitorId",
                table: "Emprestimo",
                column: "LeitorId",
                principalTable: "UsuarioSistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaEspera_UsuarioSistema_UsuarioId",
                table: "ListaEspera",
                column: "UsuarioId",
                principalTable: "UsuarioSistema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
