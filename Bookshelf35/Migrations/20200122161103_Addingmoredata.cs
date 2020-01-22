using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookshelf35.Migrations
{
    public partial class Addingmoredata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27e0f9ab-dce8-492f-9be7-0bbf832730a6", "AQAAAAEAACcQAAAAEFW+Ax7fWZN6dc2Uoeq3KiNni+jo9onpE+xz/5ccKnxZ6FCSepVXkwEQgjBSEhwtKA==" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "ApplicationUserId", "AuthorId", "Genre", "Rating", "Title", "YearPublished" },
                values: new object[,]
                {
                    { 1, "9e960334-0e68-4a6f-b05a-438250fb5564", 1, "Fantasy", 5, "Lion and some Wardrobe", 1990 },
                    { 2, "9e960334-0e68-4a6f-b05a-438250fb5564", 2, "Humor", 4, "The Twits", 1992 },
                    { 3, "aee7d25a-cdf7-45a0-8803-4a0d6979b334", 3, "Informative", 3, "This Book", 1996 }
                });

            migrationBuilder.InsertData(
                table: "Comment",
                columns: new[] { "Id", "ApplicationUserId", "BookId", "Text" },
                values: new object[,]
                {
                    { 1, "9e960334-0e68-4a6f-b05a-438250fb5564", 1, "It has a lion. 5 Stars." },
                    { 2, "aee7d25a-cdf7-45a0-8803-4a0d6979b334", 1, "Even thought I'm an athiest, I love this book." },
                    { 3, "9e960334-0e68-4a6f-b05a-438250fb5564", 2, "This is a fun guide in being a horrible person." },
                    { 4, "aee7d25a-cdf7-45a0-8803-4a0d6979b334", 2, "As a twit, I'm offended by this book." },
                    { 5, "9e960334-0e68-4a6f-b05a-438250fb5564", 3, "I LOVE This Guy's work!" },
                    { 6, "aee7d25a-cdf7-45a0-8803-4a0d6979b334", 3, "Literally who?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comment",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d3597d3-5be5-4297-a7f1-705d6cbe9c92", "AQAAAAEAACcQAAAAEOwtseNnQZoWD3Ye6XU1oj/laylteBhiRXikq+ol7SlALFNDbS0ulcObBfT2s5iRFQ==" });
        }
    }
}
