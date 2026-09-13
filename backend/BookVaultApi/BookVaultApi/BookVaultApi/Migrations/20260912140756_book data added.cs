using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookVaultApi.Migrations
{
    /// <inheritdoc />
    public partial class bookdataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublicationDate", "Quote", "Title" },
                values: new object[,]
                {
                    { 1, "Paulo Coelho", new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you want something, all the universe conspires in helping you to achieve it.", "The Alchemist" },
                    { 2, "George Orwell", new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "When you want something, all the universe conspires in helping you to achieve it.", "1984" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
