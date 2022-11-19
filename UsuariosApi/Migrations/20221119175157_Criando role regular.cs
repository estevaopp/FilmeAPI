using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a9387fe4-2449-43a3-a246-3cb976d2a194");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 2, "b7de72c7-f268-40d6-b565-4ea34a54861c", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e17274e-70a6-4b1a-a396-68adca7005e8", "AQAAAAEAACcQAAAAEA8Nh9/K5d0k7kzMDg+GrDw7x9U0HWGNz9g7t/PYurYpPcOrcMo/BuwwSjNZNNRiJw==", "b8633084-679f-492a-8b80-b237f704e65e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a10e99db-9e25-4301-bf53-11ce4892cc4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e917d6f-c235-4fdb-bcfe-9a6c2c39b0db", "AQAAAAEAACcQAAAAEBiYEMXS+4Xx3DeLL4wSAwLDrItzVNZuZKz6kne8tgnRc98D1TIJZCSJsRARGpbI/g==", "1a3834e2-be3e-4db3-badc-7fb9a4bcda7b" });
        }
    }
}
