using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Fixing2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("1c49af7b-39cb-4ef2-b3d4-6cc22482a6c9"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("2d711253-bddf-4f68-b697-c77fe3925897"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("478e70a1-123c-49c5-b13c-86fee3cc4a6d"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("644c95b3-8c11-4262-a07c-894e45cb104f"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("71e7e9a9-cc8c-4325-8b0a-daa181748ffc"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("99984987-d958-4db6-a0ed-746ca54c6443"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ba7f730f-d24c-46b4-a544-75653a741ddb"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("e8d37f9f-0897-4dee-80f3-cc6fc9e7669c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f8e08483-d7ea-4821-affa-5c133a1390cf"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("5073af1b-9c3c-4766-ae62-f9253aaf0afb"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("515ac11d-55a1-4e4b-8364-6543cd6e6154"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("b14a485d-dca4-48b6-a524-a361bc0745e9"));

            migrationBuilder.DropColumn(
                name: "CharactersId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "Tests");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<List<Guid>>(
                name: "CharactersId",
                table: "Tests",
                type: "uuid[]",
                nullable: false);

            migrationBuilder.AddColumn<List<Guid>>(
                name: "TagsId",
                table: "Tests",
                type: "uuid[]",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("5073af1b-9c3c-4766-ae62-f9253aaf0afb"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]" },
                    { new Guid("515ac11d-55a1-4e4b-8364-6543cd6e6154"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("b14a485d-dca4-48b6-a524-a361bc0745e9"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("1c49af7b-39cb-4ef2-b3d4-6cc22482a6c9"), new Guid("515ac11d-55a1-4e4b-8364-6543cd6e6154"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("2d711253-bddf-4f68-b697-c77fe3925897"), new Guid("b14a485d-dca4-48b6-a524-a361bc0745e9"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("478e70a1-123c-49c5-b13c-86fee3cc4a6d"), new Guid("515ac11d-55a1-4e4b-8364-6543cd6e6154"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("644c95b3-8c11-4262-a07c-894e45cb104f"), new Guid("515ac11d-55a1-4e4b-8364-6543cd6e6154"), "Sakura", "[\"sakura\",\"сакура\"]" },
                    { new Guid("71e7e9a9-cc8c-4325-8b0a-daa181748ffc"), new Guid("5073af1b-9c3c-4766-ae62-f9253aaf0afb"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" },
                    { new Guid("99984987-d958-4db6-a0ed-746ca54c6443"), new Guid("5073af1b-9c3c-4766-ae62-f9253aaf0afb"), "Hulk", "[\"hulk\",\"халк\"]" },
                    { new Guid("ba7f730f-d24c-46b4-a544-75653a741ddb"), new Guid("b14a485d-dca4-48b6-a524-a361bc0745e9"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("e8d37f9f-0897-4dee-80f3-cc6fc9e7669c"), new Guid("b14a485d-dca4-48b6-a524-a361bc0745e9"), "Flash", "[\"flash\",\"флэш\"]" },
                    { new Guid("f8e08483-d7ea-4821-affa-5c133a1390cf"), new Guid("5073af1b-9c3c-4766-ae62-f9253aaf0afb"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" }
                });
        }
    }
}
