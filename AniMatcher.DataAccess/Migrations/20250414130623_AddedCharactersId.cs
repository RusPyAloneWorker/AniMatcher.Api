using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedCharactersId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Franchises_Tests_TestId",
                table: "Franchises");

            migrationBuilder.DropIndex(
                name: "IX_Franchises_TestId",
                table: "Franchises");

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

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "Franchises");

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
                    { new Guid("18abb9a1-a604-4b05-b9a8-a89c02ab8573"), "Comic Franchise", "DC", "[\"dc\",\"диси\",\"дс\"]" },
                    { new Guid("483824e2-e247-4e4a-b815-aadcabda8286"), "Comic Franchise", "Marvel", "[\"marvel\",\"марвел\"]" },
                    { new Guid("9cfa065a-7916-4707-aec5-6f7d16a136a3"), "Manga Franchise", "Naruto", "[\"наруто\",\"naruto\"]" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "CopyrightId", "Name", "Names" },
                values: new object[,]
                {
                    { new Guid("16f57d18-64ed-4d3e-958c-160960ab1059"), new Guid("9cfa065a-7916-4707-aec5-6f7d16a136a3"), "Sakura", "[\"sakura\",\"сакура\"]" },
                    { new Guid("1ba1c580-75d0-4b3d-824b-3a3fbda6c609"), new Guid("18abb9a1-a604-4b05-b9a8-a89c02ab8573"), "Superman", "[\"superman\",\"супермен\",\"супермэн\"]" },
                    { new Guid("2e8509ee-eb7e-49aa-843d-8aaa50f93b47"), new Guid("9cfa065a-7916-4707-aec5-6f7d16a136a3"), "Naruto", "[\"наруто\",\"naruto\"]" },
                    { new Guid("9f2503b7-e31d-4118-9faa-df5b99bcf4b1"), new Guid("9cfa065a-7916-4707-aec5-6f7d16a136a3"), "Sasuke", "[\"саске\",\"сасуке\",\"sasuke\"]" },
                    { new Guid("a15bee74-8ee9-4ab2-a2e7-513728f1159c"), new Guid("483824e2-e247-4e4a-b815-aadcabda8286"), "Spider Man", "[\"человек-паук\",\"человек паук\",\"spider-man\",\"spider man\"]" },
                    { new Guid("b7abd319-13c1-4008-9155-72b7621b774c"), new Guid("483824e2-e247-4e4a-b815-aadcabda8286"), "Iron Man", "[\"iron man\",\"ironman\",\"железный человек\"]" },
                    { new Guid("cad81edd-425b-429f-b460-24f9668e5daf"), new Guid("18abb9a1-a604-4b05-b9a8-a89c02ab8573"), "Flash", "[\"flash\",\"флэш\"]" },
                    { new Guid("dc0c570d-83dc-4de0-977c-35b469a4a1f5"), new Guid("18abb9a1-a604-4b05-b9a8-a89c02ab8573"), "Batman", "[\"бэтмэн\",\"бэтмен\",\"batman\"]" },
                    { new Guid("f0cc3f8d-0529-443d-83fa-a8517b8651f9"), new Guid("483824e2-e247-4e4a-b815-aadcabda8286"), "Hulk", "[\"hulk\",\"халк\"]" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tags_TagName",
                table: "Tags",
                column: "TagName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tags_TagName",
                table: "Tags");

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("16f57d18-64ed-4d3e-958c-160960ab1059"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("1ba1c580-75d0-4b3d-824b-3a3fbda6c609"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("2e8509ee-eb7e-49aa-843d-8aaa50f93b47"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("9f2503b7-e31d-4118-9faa-df5b99bcf4b1"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("a15bee74-8ee9-4ab2-a2e7-513728f1159c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("b7abd319-13c1-4008-9155-72b7621b774c"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("cad81edd-425b-429f-b460-24f9668e5daf"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("dc0c570d-83dc-4de0-977c-35b469a4a1f5"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("f0cc3f8d-0529-443d-83fa-a8517b8651f9"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("18abb9a1-a604-4b05-b9a8-a89c02ab8573"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("483824e2-e247-4e4a-b815-aadcabda8286"));

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "FranchiseId",
                keyValue: new Guid("9cfa065a-7916-4707-aec5-6f7d16a136a3"));

            migrationBuilder.DropColumn(
                name: "CharactersId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TagsId",
                table: "Tests");

            migrationBuilder.AddColumn<Guid>(
                name: "TestId",
                table: "Franchises",
                type: "uuid",
                nullable: true);

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
                name: "IX_Franchises_TestId",
                table: "Franchises",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Franchises_Tests_TestId",
                table: "Franchises",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "TestId");
        }
    }
}
