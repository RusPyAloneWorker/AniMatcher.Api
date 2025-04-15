using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AniMatcher.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class TimeZoneChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tests",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Tests",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

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
        }
    }
}
