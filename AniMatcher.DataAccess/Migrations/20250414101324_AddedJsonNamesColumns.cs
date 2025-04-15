using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedJsonNamesColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("04f9df89-1da2-4b30-9de8-805b9f713e2c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("0a7734b6-50b4-4a42-9f27-008dd8a3fd1c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("141bca0d-fca2-4207-8493-f9405c8ae07b"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("3945be1a-f60e-4d88-b83f-150d9d1b37a7"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("44021a79-5507-414e-b41e-a45315c7fa47"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("65493002-5f8b-4368-87ef-674d902c7605"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("e6381bb1-67c6-4fa7-bb2a-96832af704ca"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f24bf1d9-24f3-4161-bce7-1dd557d0a3a4"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f8276a6e-fff2-4134-85ed-9e35670820bd"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("344799ad-7514-4ed8-a504-64f02e173ee5"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("75a447cb-6e63-4602-8310-dff031c69090"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("e3c740c1-dbf9-4e4c-badf-7f5d8e7b5a0c"));

            migrationBuilder.AddColumn<string>(
                name: "Names",
                table: "Franchises",
                type: "jsonb",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Names",
                table: "Characters",
                type: "jsonb",
                nullable: false,
                defaultValue: "");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Names",
                table: "Franchises");

            migrationBuilder.DropColumn(
                name: "Names",
                table: "Characters");

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "FranchiseId", "Description", "Name", "TestId" },
                values: new object[,]
                {
                    { new Guid("344799ad-7514-4ed8-a504-64f02e173ee5"), "Comic Franchise", "DC", null },
                    { new Guid("75a447cb-6e63-4602-8310-dff031c69090"), "Manga Franchise", "Naruto", null },
                    { new Guid("e3c740c1-dbf9-4e4c-badf-7f5d8e7b5a0c"), "Comic Franchise", "Marvel", null }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "TestId" },
                values: new object[,]
                {
                    { new Guid("04f9df89-1da2-4b30-9de8-805b9f713e2c"), new Guid("344799ad-7514-4ed8-a504-64f02e173ee5"), "Batman", null },
                    { new Guid("0a7734b6-50b4-4a42-9f27-008dd8a3fd1c"), new Guid("344799ad-7514-4ed8-a504-64f02e173ee5"), "Superman", null },
                    { new Guid("141bca0d-fca2-4207-8493-f9405c8ae07b"), new Guid("75a447cb-6e63-4602-8310-dff031c69090"), "Sakura", null },
                    { new Guid("3945be1a-f60e-4d88-b83f-150d9d1b37a7"), new Guid("e3c740c1-dbf9-4e4c-badf-7f5d8e7b5a0c"), "Spider Man", null },
                    { new Guid("44021a79-5507-414e-b41e-a45315c7fa47"), new Guid("e3c740c1-dbf9-4e4c-badf-7f5d8e7b5a0c"), "Iron Man", null },
                    { new Guid("65493002-5f8b-4368-87ef-674d902c7605"), new Guid("e3c740c1-dbf9-4e4c-badf-7f5d8e7b5a0c"), "Hulk", null },
                    { new Guid("e6381bb1-67c6-4fa7-bb2a-96832af704ca"), new Guid("75a447cb-6e63-4602-8310-dff031c69090"), "Sasuke", null },
                    { new Guid("f24bf1d9-24f3-4161-bce7-1dd557d0a3a4"), new Guid("75a447cb-6e63-4602-8310-dff031c69090"), "Naruto", null },
                    { new Guid("f8276a6e-fff2-4134-85ed-9e35670820bd"), new Guid("344799ad-7514-4ed8-a504-64f02e173ee5"), "Flash", null }
                });
        }
    }
}
