using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookVaultApi.Migrations
{
    /// <inheritdoc />
    public partial class MoreBookDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quote",
                value: "Big Brother is watching you.");

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PublicationDate", "Quote", "Title" },
                values: new object[,]
                {
                    { 3, "Harper Lee", new DateTime(1960, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "You never really understand a person until you consider things from his point of view.", "To Kill a Mockingbird" },
                    { 4, "F. Scott Fitzgerald", new DateTime(1925, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "So we beat on, boats against the current, borne back ceaselessly into the past.", "The Great Gatsby" },
                    { 5, "Jane Austen", new DateTime(1813, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "It is a truth universally acknowledged.", "Pride and Prejudice" },
                    { 6, "J.R.R. Tolkien", new DateTime(1937, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Not all those who wander are lost.", "The Hobbit" },
                    { 7, "J.K. Rowling", new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "It does not do to dwell on dreams and forget to live.", "Harry Potter and the Philosopher's Stone" },
                    { 8, "Markus Zusak", new DateTime(2005, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "I am haunted by humans.", "The Book Thief" },
                    { 9, "Antoine de Saint-Exupéry", new DateTime(1943, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "What is essential is invisible to the eye.", "The Little Prince" },
                    { 10, "James Clear", new DateTime(2018, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Every action you take is a vote for the person you wish to become.", "Atomic Habits" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Quote",
                value: "When you want something, all the universe conspires in helping you to achieve it.");
        }
    }
}
