using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Facil.BioCentro.Migrations
{
    /// <inheritdoc />
    public partial class RemovePrefixo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppProfissionais",
                table: "AppProfissionais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppClientes",
                table: "AppClientes");

            migrationBuilder.RenameTable(
                name: "AppProfissionais",
                newName: "Profissionais");

            migrationBuilder.RenameTable(
                name: "AppClientes",
                newName: "Clientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Profissionais",
                table: "Profissionais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Profissionais",
                newName: "AppProfissionais");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "AppClientes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppProfissionais",
                table: "AppProfissionais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppClientes",
                table: "AppClientes",
                column: "Id");
        }
    }
}
