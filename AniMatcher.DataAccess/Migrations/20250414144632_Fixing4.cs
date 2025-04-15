using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Fixing4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("109b9918-a406-4b88-a45a-847377ab29dd"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("1f2b3716-93f0-4ca6-9400-271c28e4c174"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("479aab0d-3ba3-4236-8ba3-e64ebddbc630"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("4ecf7e23-6f80-44b3-910f-0371137d7d8c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("665acda2-5c2c-404d-a34b-d77e2d5b16aa"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("882c7e94-e03a-4853-afcc-b04905724783"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("a872f2e7-90ab-4087-a801-cfb2e18a7907"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("b840a79b-39e0-43bd-8dfc-9fa2958d93c0"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("c164d15c-0908-45a8-a5d4-deb1e0855f2b"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("4a9848f1-d16b-4b58-a4b9-65c940f10ea8"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("cd20d03f-d6f5-4696-ae0b-b6d4ca9396ac"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("d8dcbabb-649f-40e7-bd41-c505c2d4459b"));

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("638366e4-0701-4872-a9b3-94c95494b54a"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("85ae4d0b-51af-4b65-9f60-3fce549f64c1"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]" },
                    { new Guid("cf45d0e0-8db9-4772-afc5-ad03f667ac43"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("0176db48-04b6-4bcc-a94b-18576f97ca16"), new Guid("638366e4-0701-4872-a9b3-94c95494b54a"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("7b5c7b24-ac44-4752-a60a-2c26217f57e4"), new Guid("638366e4-0701-4872-a9b3-94c95494b54a"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("8cee8921-79ad-466c-be99-ec4abb0ca398"), new Guid("85ae4d0b-51af-4b65-9f60-3fce549f64c1"), "Hulk", "[\"hulk\",\"халк\"]" },
                    { new Guid("936e8189-94a6-4a4f-a195-2f3729ff1614"), new Guid("cf45d0e0-8db9-4772-afc5-ad03f667ac43"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("9835eef3-3c94-441d-bd31-e3f984b6d6b4"), new Guid("85ae4d0b-51af-4b65-9f60-3fce549f64c1"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" },
                    { new Guid("cef2c22e-01c3-4fc2-8c66-d12afddbba0e"), new Guid("cf45d0e0-8db9-4772-afc5-ad03f667ac43"), "Flash", "[\"flash\",\"флэш\"]" },
                    { new Guid("e71a7198-1368-4d89-ad9e-94133aaa99b7"), new Guid("cf45d0e0-8db9-4772-afc5-ad03f667ac43"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("ea4d1129-25b0-430f-ab8a-f5cde94a5788"), new Guid("638366e4-0701-4872-a9b3-94c95494b54a"), "Sakura", "[\"sakura\",\"сакура\"]" },
                    { new Guid("ff334248-4210-448a-a065-d8fcc511a3d8"), new Guid("85ae4d0b-51af-4b65-9f60-3fce549f64c1"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("0176db48-04b6-4bcc-a94b-18576f97ca16"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("7b5c7b24-ac44-4752-a60a-2c26217f57e4"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("8cee8921-79ad-466c-be99-ec4abb0ca398"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("936e8189-94a6-4a4f-a195-2f3729ff1614"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("9835eef3-3c94-441d-bd31-e3f984b6d6b4"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("cef2c22e-01c3-4fc2-8c66-d12afddbba0e"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("e71a7198-1368-4d89-ad9e-94133aaa99b7"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ea4d1129-25b0-430f-ab8a-f5cde94a5788"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ff334248-4210-448a-a065-d8fcc511a3d8"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("638366e4-0701-4872-a9b3-94c95494b54a"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("85ae4d0b-51af-4b65-9f60-3fce549f64c1"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("cf45d0e0-8db9-4772-afc5-ad03f667ac43"));

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("4a9848f1-d16b-4b58-a4b9-65c940f10ea8"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]" },
                    { new Guid("cd20d03f-d6f5-4696-ae0b-b6d4ca9396ac"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("d8dcbabb-649f-40e7-bd41-c505c2d4459b"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("109b9918-a406-4b88-a45a-847377ab29dd"), new Guid("d8dcbabb-649f-40e7-bd41-c505c2d4459b"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" },
                    { new Guid("1f2b3716-93f0-4ca6-9400-271c28e4c174"), new Guid("d8dcbabb-649f-40e7-bd41-c505c2d4459b"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" },
                    { new Guid("479aab0d-3ba3-4236-8ba3-e64ebddbc630"), new Guid("cd20d03f-d6f5-4696-ae0b-b6d4ca9396ac"), "Sakura", "[\"sakura\",\"сакура\"]" },
                    { new Guid("4ecf7e23-6f80-44b3-910f-0371137d7d8c"), new Guid("4a9848f1-d16b-4b58-a4b9-65c940f10ea8"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("665acda2-5c2c-404d-a34b-d77e2d5b16aa"), new Guid("cd20d03f-d6f5-4696-ae0b-b6d4ca9396ac"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("882c7e94-e03a-4853-afcc-b04905724783"), new Guid("4a9848f1-d16b-4b58-a4b9-65c940f10ea8"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("a872f2e7-90ab-4087-a801-cfb2e18a7907"), new Guid("cd20d03f-d6f5-4696-ae0b-b6d4ca9396ac"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("b840a79b-39e0-43bd-8dfc-9fa2958d93c0"), new Guid("d8dcbabb-649f-40e7-bd41-c505c2d4459b"), "Hulk", "[\"hulk\",\"халк\"]" },
                    { new Guid("c164d15c-0908-45a8-a5d4-deb1e0855f2b"), new Guid("4a9848f1-d16b-4b58-a4b9-65c940f10ea8"), "Flash", "[\"flash\",\"флэш\"]" }
                });
        }
    }
}
