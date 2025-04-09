using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Franchises_CopyrightFranchiseId",
                table: "Characters");

            migrationBuilder.RenameColumn(
                name: "CopyrightFranchiseId",
                table: "Characters",
                newName: "CopyrightId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_CopyrightFranchiseId",
                table: "Characters",
                newName: "IX_Characters_CopyrightId");

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "TestId" },
                values: new object[,]
                {
                    { new Guid("2c08c4ad-d038-43b3-9428-3d6857eb8c4d"), "Comic Franchise", "Marvel", null },
                    { new Guid("ca30e999-a548-4475-be95-958a0ced8b22"), "Comic Franchise", "DC", null },
                    { new Guid("eac17e4f-2f16-473a-a0a7-be8d78aa9b0a"), "Manga Franchise", "Naruto", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Franchises_CopyrightId",
                table: "Characters",
                column: "CopyrightId",
                principalTable: "Franchises",
                principalColumn: "FranchiseId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Franchises_CopyrightId",
                table: "Characters");

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

            migrationBuilder.RenameColumn(
                name: "CopyrightId",
                table: "Characters",
                newName: "CopyrightFranchiseId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_CopyrightId",
                table: "Characters",
                newName: "IX_Characters_CopyrightFranchiseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Franchises_CopyrightFranchiseId",
                table: "Characters",
                column: "CopyrightFranchiseId",
                principalTable: "Franchises",
                principalColumn: "FranchiseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
