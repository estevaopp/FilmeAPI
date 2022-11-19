using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class AjeitandonomeDataNasciemntoparaDataNascimento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataNasciemnto",
                table: "AspNetUsers",
                newName: "DataNascimento");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9eca0916-8a45-4442-a6a8-52de7a018c8d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "fa323d6b-4fc6-4b4c-b581-5716c34140d3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bab4a6c9-01c5-4685-88dc-f67b4d8a3d89", "AQAAAAEAACcQAAAAEIIxv9vL5P+xve6NdHo6Mkk2cvrZ1NeQa27AeDxi2OZ7XSRtrUe/KGceB6iuHhyDSw==", "18813637-a770-43f3-a4e5-f84eaad8812b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "AspNetUsers",
                newName: "DataNasciemnto");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "bcbe8ade-56a1-428a-8e55-ab625e735144");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "65e56a0d-7e42-4a14-818c-37f31a9dd247");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eded6320-4ddf-4faa-9d7a-b37506669f60", "AQAAAAEAACcQAAAAEE9g4WhypxcfhjoD9XGHM82McBCkK9PDDdwVUQrH8cXIZ0oIeinzl6bOZOnxBQhD1g==", "f3be6859-a2cf-44cc-a3fd-ca107a3ca5cc" });
        }
    }
}
