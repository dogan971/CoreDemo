using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abouts",
                columns: table => new
                {
                    aboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abouts", x => x.aboutID);
                });

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryID);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    contactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    contactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    contactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.contactID);
                });

            migrationBuilder.CreateTable(
                name: "writers",
                columns: table => new
                {
                    writerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    writerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    writerPassword = table.Column<int>(type: "int", nullable: false),
                    writerStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_writers", x => x.writerID);
                });

            migrationBuilder.CreateTable(
                name: "blogs",
                columns: table => new
                {
                    blogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    blogContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    blogStatus = table.Column<bool>(type: "bit", nullable: false),
                    blogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    categoryID = table.Column<int>(type: "int", nullable: false),
                    writerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blogs", x => x.blogID);
                    table.ForeignKey(
                        name: "FK_blogs_categories_categoryID",
                        column: x => x.categoryID,
                        principalTable: "categories",
                        principalColumn: "categoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_blogs_writers_writerID",
                        column: x => x.writerID,
                        principalTable: "writers",
                        principalColumn: "writerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    commentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    commentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    commentStatus = table.Column<bool>(type: "bit", nullable: false),
                    blogID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.commentID);
                    table.ForeignKey(
                        name: "FK_comments_blogs_blogID",
                        column: x => x.blogID,
                        principalTable: "blogs",
                        principalColumn: "blogID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_blogs_categoryID",
                table: "blogs",
                column: "categoryID");

            migrationBuilder.CreateIndex(
                name: "IX_blogs_writerID",
                table: "blogs",
                column: "writerID");

            migrationBuilder.CreateIndex(
                name: "IX_comments_blogID",
                table: "comments",
                column: "blogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "abouts");

            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "blogs");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "writers");
        }
    }
}
