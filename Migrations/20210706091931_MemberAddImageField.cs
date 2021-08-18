using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathModeling21.Migrations
{
    public partial class MemberAddImageField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Members",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 6, 16, 19, 31, 89, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "");

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 6, 16, 19, 31, 92, DateTimeKind.Local).AddTicks(3432));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Members");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 6, 22, 11, 40, 3, 135, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 6, 22, 11, 40, 3, 138, DateTimeKind.Local).AddTicks(7669));
        }
    }
}
