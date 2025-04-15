using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedManyToManyRelationBetweenCharacterAndTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Tests_TestId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_TestId",
                table: "Characters");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("02a8b588-7cbc-4f0d-a581-ca53e4bd81b8"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("0d2a9901-ad20-45e1-92d4-e23ba622d255"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("2350f880-02f7-4e6d-a54f-97f28ec82ca3"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("264e82f4-f727-4e98-84e8-ff76be3c1f80"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("30432432-09a2-441e-84ff-c055e50a5914"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("6b4fc59c-02f5-42a6-8895-cf585f9e55c1"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ac7289e8-da90-4f79-8c81-37f1ca8cb668"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("de57e157-df96-42a6-993d-cc1458f60dd1"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f1c18faf-4487-4c3f-92cf-14beded85de3"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("593fbaa3-d6ea-42bd-8db7-45c4330eead7"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("5ceddbd1-ee1d-49d7-a8fc-ecc259ce2ac7"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("bf5f64d4-40d5-4a47-9c8b-8fd64a788900"));

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Characters");

            migrationBuilder.CreateTable(
                name: "CharacterTest",
                columns: table => new
                {
                    CharactersCharacterId = table.Column<Guid>(type: "uuid", nullable: false),
                    TestId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterTest", x => new { x.CharactersCharacterId, x.TestId });
                    table.ForeignKey(
                        name: "FK_CharacterTest_Characters_CharactersCharacterId",
                        column: x => x.CharactersCharacterId,
                        principalTable: "Characters",
                        principalColumn: "CharacterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterTest_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names", "TestId" },
                values: new object[,]
                {
                    { new Guid("281a8601-0d18-4507-877c-dfe85d2fd0ef"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]", null },
                    { new Guid("a8f77239-b424-444b-b809-f515aff6b717"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]", null },
                    { new Guid("e82766fb-6a3e-498f-a167-d15af24c723b"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]", null }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("0a5cd913-7c10-42fa-8119-10193f5d7fe8"), new Guid("281a8601-0d18-4507-877c-dfe85d2fd0ef"), "Flash", "[\"flash\",\"флэш\"]" },
                    { new Guid("13787b25-de0d-43ac-aba7-6f1cd5a54bed"), new Guid("e82766fb-6a3e-498f-a167-d15af24c723b"), "Sakura", "[\"sakura\",\"сакура\"]" },
                    { new Guid("32b91f9b-fec7-49db-9511-0d8b5964e231"), new Guid("e82766fb-6a3e-498f-a167-d15af24c723b"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("4a3d87c4-1d48-4a45-b61e-24223475584e"), new Guid("281a8601-0d18-4507-877c-dfe85d2fd0ef"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("53a52954-ea07-4f7b-895c-9edb4ff71fea"), new Guid("e82766fb-6a3e-498f-a167-d15af24c723b"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("ae7dec5f-5958-4e08-a3de-ca35faaabe22"), new Guid("a8f77239-b424-444b-b809-f515aff6b717"), "Hulk", "[\"hulk\",\"халк\"]" },
                    { new Guid("b9ae3d10-ccd3-43d3-b14f-7b6ead55a4da"), new Guid("281a8601-0d18-4507-877c-dfe85d2fd0ef"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("da0a27b2-4335-41f9-bfcf-877da7c488cb"), new Guid("a8f77239-b424-444b-b809-f515aff6b717"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" },
                    { new Guid("e8d571a6-23b5-4672-916a-def52443e18f"), new Guid("a8f77239-b424-444b-b809-f515aff6b717"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterTest_TestId",
                table: "CharacterTest",
                column: "TestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterTest");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("0a5cd913-7c10-42fa-8119-10193f5d7fe8"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("13787b25-de0d-43ac-aba7-6f1cd5a54bed"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("32b91f9b-fec7-49db-9511-0d8b5964e231"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("4a3d87c4-1d48-4a45-b61e-24223475584e"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("53a52954-ea07-4f7b-895c-9edb4ff71fea"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ae7dec5f-5958-4e08-a3de-ca35faaabe22"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("b9ae3d10-ccd3-43d3-b14f-7b6ead55a4da"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("da0a27b2-4335-41f9-bfcf-877da7c488cb"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("e8d571a6-23b5-4672-916a-def52443e18f"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("281a8601-0d18-4507-877c-dfe85d2fd0ef"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("a8f77239-b424-444b-b809-f515aff6b717"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("e82766fb-6a3e-498f-a167-d15af24c723b"));

            migrationBuilder.AddColumn<Guid>(
                name: "TestId",
                table: "Characters",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names", "TestId" },
                values: new object[,]
                {
                    { new Guid("593fbaa3-d6ea-42bd-8db7-45c4330eead7"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]", null },
                    { new Guid("5ceddbd1-ee1d-49d7-a8fc-ecc259ce2ac7"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]", null },
                    { new Guid("bf5f64d4-40d5-4a47-9c8b-8fd64a788900"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]", null }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names", "TestId" },
                values: new object[,]
                {
                    { new Guid("02a8b588-7cbc-4f0d-a581-ca53e4bd81b8"), new Guid("bf5f64d4-40d5-4a47-9c8b-8fd64a788900"), "Sakura", "[\"sakura\",\"сакура\"]", null },
                    { new Guid("0d2a9901-ad20-45e1-92d4-e23ba622d255"), new Guid("bf5f64d4-40d5-4a47-9c8b-8fd64a788900"), "Naruto", "[\"наруто\",\"naruto\"]", null },
                    { new Guid("2350f880-02f7-4e6d-a54f-97f28ec82ca3"), new Guid("5ceddbd1-ee1d-49d7-a8fc-ecc259ce2ac7"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]", null },
                    { new Guid("264e82f4-f727-4e98-84e8-ff76be3c1f80"), new Guid("593fbaa3-d6ea-42bd-8db7-45c4330eead7"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]", null },
                    { new Guid("30432432-09a2-441e-84ff-c055e50a5914"), new Guid("593fbaa3-d6ea-42bd-8db7-45c4330eead7"), "Flash", "[\"flash\",\"флэш\"]", null },
                    { new Guid("6b4fc59c-02f5-42a6-8895-cf585f9e55c1"), new Guid("bf5f64d4-40d5-4a47-9c8b-8fd64a788900"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]", null },
                    { new Guid("ac7289e8-da90-4f79-8c81-37f1ca8cb668"), new Guid("5ceddbd1-ee1d-49d7-a8fc-ecc259ce2ac7"), "Hulk", "[\"hulk\",\"халк\"]", null },
                    { new Guid("de57e157-df96-42a6-993d-cc1458f60dd1"), new Guid("5ceddbd1-ee1d-49d7-a8fc-ecc259ce2ac7"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]", null },
                    { new Guid("f1c18faf-4487-4c3f-92cf-14beded85de3"), new Guid("593fbaa3-d6ea-42bd-8db7-45c4330eead7"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_TestId",
                table: "Characters",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Tests_TestId",
                table: "Characters",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId");
        }
    }
}
