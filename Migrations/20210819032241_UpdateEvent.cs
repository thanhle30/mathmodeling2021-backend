using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathModeling21.Migrations
{
    public partial class UpdateEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brief",
                table: "Events",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsBigEvent",
                table: "Events",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 8, 19, 10, 22, 40, 758, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Brief", "IsBigEvent" },
                values: new object[] { "This Info Session covers math modeling.", true });

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 8, 19, 10, 22, 40, 761, DateTimeKind.Local).AddTicks(3642));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brief",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "IsBigEvent",
                table: "Events");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 11, 14, 12, 53, 502, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "Messages",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostDate",
                value: new DateTime(2021, 7, 11, 14, 12, 53, 505, DateTimeKind.Local).AddTicks(523));
        }
    }
}
