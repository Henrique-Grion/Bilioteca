using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bilioteca.Migrations
{
    /// <inheritdoc />
    public partial class TabelaListaEspera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListaEspera",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    LivroId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataEntrada = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Posicao = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListaEspera", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListaEspera_Livros_LivroId",
                        column: x => x.LivroId,
                        principalTable: "Livros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ListaEspera_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListaEspera_LivroId_UsuarioId",
                table: "ListaEspera",
                columns: new[] { "LivroId", "UsuarioId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ListaEspera_UsuarioId",
                table: "ListaEspera",
                column: "UsuarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListaEspera");
        }
    }
}
