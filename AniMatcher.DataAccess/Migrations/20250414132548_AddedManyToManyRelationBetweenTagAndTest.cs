using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedManyToManyRelationBetweenTagAndTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Tests_TestId",
                table: "Tags");

            migrationBuilder.DropIndex(
                name: "IX_Tags_TestId",
                table: "Tags");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("0134a82f-e535-49ac-9663-dbaf34c62691"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("120108a0-c28c-4a23-8015-2bee4cf9fb93"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("5141b749-c57f-492a-bed9-820cc4fd4633"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("72436d46-9f64-4338-86c3-a2b5404f3bb5"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("8920021e-687d-4f58-8ae4-3e3837c30da9"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("8b8230ce-ccde-4ec0-bba5-b4ff2bfcc73e"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("af9f8ca0-69c9-4f97-bded-40ed3f0066d0"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("e75ec5e1-1a8a-4afc-bd9b-dd931c491015"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("ef2f1f0a-61ca-41a1-bb7f-7fe022422826"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("1918fde4-57f8-4a55-b27b-310e15b7aaa3"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("30cc1f7f-d383-499b-babc-e4a7e4dc8565"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("5dadb7d7-4f91-40af-bdc7-2c76811f60d1"));

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Tags");

            migrationBuilder.CreateTable(
                name: "TagTest",
                columns: table => new
                {
                    TagsTagId = table.Column<Guid>(type: "uuid", nullable: false),
                    TestId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagTest", x => new { x.TagsTagId, x.TestId });
                    table.ForeignKey(
                        name: "FK_TagTest_Tags_TagsTagId",
                        column: x => x.TagsTagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagTest_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "TestId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TagTest_TestId",
                table: "TagTest",
                column: "TestId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TagTest");

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

            migrationBuilder.AddColumn<Guid>(
                name: "TestId",
                table: "Tags",
                type: "uuid",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("1918fde4-57f8-4a55-b27b-310e15b7aaa3"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]" },
                    { new Guid("30cc1f7f-d383-499b-babc-e4a7e4dc8565"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]" },
                    { new Guid("5dadb7d7-4f91-40af-bdc7-2c76811f60d1"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("0134a82f-e535-49ac-9663-dbaf34c62691"), new Guid("1918fde4-57f8-4a55-b27b-310e15b7aaa3"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" },
                    { new Guid("120108a0-c28c-4a23-8015-2bee4cf9fb93"), new Guid("30cc1f7f-d383-499b-babc-e4a7e4dc8565"), "Flash", "[\"flash\",\"флэш\"]" },
                    { new Guid("5141b749-c57f-492a-bed9-820cc4fd4633"), new Guid("5dadb7d7-4f91-40af-bdc7-2c76811f60d1"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("72436d46-9f64-4338-86c3-a2b5404f3bb5"), new Guid("1918fde4-57f8-4a55-b27b-310e15b7aaa3"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" },
                    { new Guid("8920021e-687d-4f58-8ae4-3e3837c30da9"), new Guid("30cc1f7f-d383-499b-babc-e4a7e4dc8565"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("8b8230ce-ccde-4ec0-bba5-b4ff2bfcc73e"), new Guid("30cc1f7f-d383-499b-babc-e4a7e4dc8565"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("af9f8ca0-69c9-4f97-bded-40ed3f0066d0"), new Guid("5dadb7d7-4f91-40af-bdc7-2c76811f60d1"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("e75ec5e1-1a8a-4afc-bd9b-dd931c491015"), new Guid("1918fde4-57f8-4a55-b27b-310e15b7aaa3"), "Hulk", "[\"hulk\",\"халк\"]" },
                    { new Guid("ef2f1f0a-61ca-41a1-bb7f-7fe022422826"), new Guid("5dadb7d7-4f91-40af-bdc7-2c76811f60d1"), "Sakura", "[\"sakura\",\"сакура\"]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TestId",
                table: "Tags",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Tests_TestId",
                table: "Tags",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId");
        }
    }
}
