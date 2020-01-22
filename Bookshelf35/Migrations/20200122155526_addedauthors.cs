using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf35.Migrations
{
    public partial class addedauthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d3597d3-5be5-4297-a7f1-705d6cbe9c92", "AQAAAAEAACcQAAAAEOwtseNnQZoWD3Ye6XU1oj/laylteBhiRXikq+ol7SlALFNDbS0ulcObBfT2s5iRFQ==" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { 1, "9e960334-0e68-4a6f-b05a-438250fb5564", "CS Lewis" },
                    { 2, "9e960334-0e68-4a6f-b05a-438250fb5564", "Rahl Dohl" },
                    { 3, "aee7d25a-cdf7-45a0-8803-4a0d6979b334", "This Guy" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0b7d3de1-fe1d-4adb-8e3e-d940d68e4a96", "AQAAAAEAACcQAAAAEFdvHdzxL/kviYclqbVxpv1DdSqg2gaKoigvXBaN9CZphpf7rD+j5Zl5ADFVvA/Tzg==" });

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "ApplicationUserId", "Name" },
                values: new object[,]
                {
                    { -1, "9e960334-0e68-4a6f-b05a-438250fb5564", "CS Lewis" },
                    { -2, "9e960334-0e68-4a6f-b05a-438250fb5564", "Rahl Dohl" },
                    { -3, "aee7d25a-cdf7-45a0-8803-4a0d6979b334", "This Guy" }
                });
        }
    }
}
