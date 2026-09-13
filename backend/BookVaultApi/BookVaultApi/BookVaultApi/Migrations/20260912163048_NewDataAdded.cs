using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookVaultApi.Migrations
{
    /// <inheritdoc />
    public partial class NewDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublicationDate", "Quote", "Title" },
                values: new object[] { 11, "James Clear", new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Every action you take is a vote for the person you wish to become.", "test" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
