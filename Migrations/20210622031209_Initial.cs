using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathModeling21.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    PostDate = table.Column<DateTime>(nullable: false),
                    ImagesStr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faq",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faq", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Media",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Media", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Gif = table.Column<string>(nullable: true),
                    FacebookUrl = table.Column<string>(nullable: true),
                    InstagramUrl = table.Column<string>(nullable: true),
                    LinkedInUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    PostDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Body", "ImagesStr", "PostDate", "Title" },
                values: new object[] { 1, @"This page shares my best articles to read on topics like health, happiness, creativity, productivity and more. The central question that drives my work is, “How can we live better?” To answer that question, I like to write about science-based ways to solve practical problems.
You’ll find interesting articles to read on topics like how to stop procrastinating as well as personal recommendations like my list of the best books to read and my minimalist travel guide.Ready to dive in? You can use the categories below to browse my best articles.", "asffsfssfshoian-26.jpg,feffsfsf3434vietnam-travel.jpg", new DateTime(2021, 6, 22, 10, 12, 9, 246, DateTimeKind.Local).AddTicks(9151), "Sample Article" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Body", "Date", "Image", "Name" },
                values: new object[] { 1, "This Info Session covers fundamental knowledge about math modeling. This Info Session covers fundamental knowledge about math modeling.", new DateTime(2021, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "asffsfssfshoian-26.jpg", "Sample Event" });

            migrationBuilder.InsertData(
                table: "Faq",
                columns: new[] { "Id", "Answer", "Question" },
                values: new object[] { 1, "Xin lỗi bạn. Đối tượng tham gia là học sinh cấp ba.", "Mình là sinh viên năm nhất. Mình có thể tham gia cuộc thi không?" });

            migrationBuilder.InsertData(
                table: "Media",
                columns: new[] { "Id", "Image", "Year" },
                values: new object[] { 1, "feffsfsf3434vietnam-travel.jpg", 2018 });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "FacebookUrl", "Gif", "InstagramUrl", "LinkedInUrl", "Name", "Role" },
                values: new object[] { 1, "https://www.facebook.com/hai.nguyenngoc.129794", "", "", "", "Nguyễn Ngọc Hải", "Trưởng Ban Tổ Chức" });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Body", "Email", "FullName", "PhoneNumber", "PostDate" },
                values: new object[] { 1, "Mong admin facebook rep tin nhắn em sớm ạ. Em cảm ơn.", "levinguyen@email.co", "Levi Nguyen", "0379111111", new DateTime(2021, 6, 22, 10, 12, 9, 249, DateTimeKind.Local).AddTicks(6407) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Faq");

            migrationBuilder.DropTable(
                name: "Media");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Messages");
        }
    }
}
