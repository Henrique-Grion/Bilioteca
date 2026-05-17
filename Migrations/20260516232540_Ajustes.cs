using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bilioteca.Migrations
{
    /// <inheritdoc />
    public partial class Ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_FuncionarioId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_Emprestimo_Usuario_LeitorId",
                table: "Emprestimo");

            migrationBuilder.DropForeignKey(
                name: "FK_ListaEspera_Usuario_UsuarioId",
                table: "ListaEspera");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.CreateTable(
                name: "UsuarioSistema",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioSistema", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "UsuarioSistema");

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_FuncionarioId",
                table: "Emprestimo",
                column: "FuncionarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Emprestimo_Usuario_LeitorId",
                table: "Emprestimo",
                column: "LeitorId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ListaEspera_Usuario_UsuarioId",
                table: "ListaEspera",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
