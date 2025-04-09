using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Initial03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
