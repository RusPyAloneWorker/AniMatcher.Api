using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixingRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("068c1168-8480-4f79-8db2-5fe59bfba1eb"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("695a7c18-1ac6-4a6d-829b-e9177c96fccc"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("a85cb53c-4490-4e16-9374-bfbee1bf2b41"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("a9d773e8-6eff-4714-aab9-b9fcc9ff2cd3"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ac655977-2edb-4a97-8f34-2d559a37834b"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("b496a10a-0c18-4c65-9a3d-2be542fa681f"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ddbf5ebd-5c12-4a92-9670-52372c2ea998"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f1902339-820c-4f99-8b67-11191ba66c7c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f68625cd-80ee-47fa-a5c5-7fa9c75e0f07"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("14af0b88-ffeb-4b3a-9c73-3ec89afbc552"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("7ae1c4c1-c04f-45dd-ab5b-a8322ecb9a5f"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("8ab40fc6-02cf-49dd-9c55-3f6452d9cfe8"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("14af0b88-ffeb-4b3a-9c73-3ec89afbc552"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]" },
                    { new Guid("7ae1c4c1-c04f-45dd-ab5b-a8322ecb9a5f"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("8ab40fc6-02cf-49dd-9c55-3f6452d9cfe8"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("068c1168-8480-4f79-8db2-5fe59bfba1eb"), new Guid("8ab40fc6-02cf-49dd-9c55-3f6452d9cfe8"), "Flash", "[\"flash\",\"флэш\"]" },
                    { new Guid("695a7c18-1ac6-4a6d-829b-e9177c96fccc"), new Guid("8ab40fc6-02cf-49dd-9c55-3f6452d9cfe8"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("a85cb53c-4490-4e16-9374-bfbee1bf2b41"), new Guid("14af0b88-ffeb-4b3a-9c73-3ec89afbc552"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" },
                    { new Guid("a9d773e8-6eff-4714-aab9-b9fcc9ff2cd3"), new Guid("8ab40fc6-02cf-49dd-9c55-3f6452d9cfe8"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("ac655977-2edb-4a97-8f34-2d559a37834b"), new Guid("7ae1c4c1-c04f-45dd-ab5b-a8322ecb9a5f"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("b496a10a-0c18-4c65-9a3d-2be542fa681f"), new Guid("7ae1c4c1-c04f-45dd-ab5b-a8322ecb9a5f"), "Sakura", "[\"sakura\",\"сакура\"]" },
                    { new Guid("ddbf5ebd-5c12-4a92-9670-52372c2ea998"), new Guid("14af0b88-ffeb-4b3a-9c73-3ec89afbc552"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" },
                    { new Guid("f1902339-820c-4f99-8b67-11191ba66c7c"), new Guid("7ae1c4c1-c04f-45dd-ab5b-a8322ecb9a5f"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("f68625cd-80ee-47fa-a5c5-7fa9c75e0f07"), new Guid("14af0b88-ffeb-4b3a-9c73-3ec89afbc552"), "Hulk", "[\"hulk\",\"халк\"]" }
                });
        }
    }
}
