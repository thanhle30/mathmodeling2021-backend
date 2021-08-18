using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathModeling21.Migrations
{
    public partial class MessageAddReviewStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ReviewStatus",
                table: "Messages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 7, 15, 35, 30, 506, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 7, 15, 35, 30, 508, DateTimeKind.Local).AddTicks(8231));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewStatus",
                table: "Messages");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 6, 16, 19, 31, 89, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 6, 16, 19, 31, 92, DateTimeKind.Local).AddTicks(3432));
        }
    }
}
