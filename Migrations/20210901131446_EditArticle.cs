using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathModeling21.Migrations
{
    public partial class EditArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagesStr",
                table: "Articles");

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Articles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 9, 1, 9, 14, 45, 840, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 9, 1, 9, 14, 45, 845, DateTimeKind.Local).AddTicks(3476));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Articles");

            migrationBuilder.AddColumn<string>(
                name: "ImagesStr",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagesStr", "PostDate" },
                values: new object[] { "asffsfssfshoian-26.jpg,feffsfsf3434vietnam-travel.jpg", new DateTime(2021, 8, 19, 10, 22, 40, 758, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 8, 19, 10, 22, 40, 761, DateTimeKind.Local).AddTicks(3642));
        }
    }
}
