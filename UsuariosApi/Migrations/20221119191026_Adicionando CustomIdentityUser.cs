using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class AdicionandoCustomIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasciemnto",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNasciemnto",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a9387fe4-2449-43a3-a246-3cb976d2a194");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b7de72c7-f268-40d6-b565-4ea34a54861c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e17274e-70a6-4b1a-a396-68adca7005e8", "AQAAAAEAACcQAAAAEA8Nh9/K5d0k7kzMDg+GrDw7x9U0HWGNz9g7t/PYurYpPcOrcMo/BuwwSjNZNNRiJw==", "b8633084-679f-492a-8b80-b237f704e65e" });
        }
    }
}
