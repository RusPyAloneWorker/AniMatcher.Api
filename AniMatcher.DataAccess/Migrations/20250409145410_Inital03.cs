using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Inital03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("2c08c4ad-d038-43b3-9428-3d6857eb8c4d"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("ca30e999-a548-4475-be95-958a0ced8b22"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("eac17e4f-2f16-473a-a0a7-be8d78aa9b0a"));

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "TestId" },
                values: new object[,]
                {
                    { new Guid("008520f0-2f63-4b4c-9656-fd025ab5a888"), "Comic Franchise", "Marvel", null },
                    { new Guid("52bf3aa8-1e1f-4de1-924c-0c818adbf50e"), "Manga Franchise", "Naruto", null },
                    { new Guid("e73c0f8f-af21-4afd-9614-b6265db390ad"), "Comic Franchise", "DC", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("008520f0-2f63-4b4c-9656-fd025ab5a888"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("52bf3aa8-1e1f-4de1-924c-0c818adbf50e"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("e73c0f8f-af21-4afd-9614-b6265db390ad"));

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "TestId" },
                values: new object[,]
                {
                    { new Guid("2c08c4ad-d038-43b3-9428-3d6857eb8c4d"), "Comic Franchise", "Marvel", null },
                    { new Guid("ca30e999-a548-4475-be95-958a0ced8b22"), "Comic Franchise", "DC", null },
                    { new Guid("eac17e4f-2f16-473a-a0a7-be8d78aa9b0a"), "Manga Franchise", "Naruto", null }
                });
        }
    }
}
