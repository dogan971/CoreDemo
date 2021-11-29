using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace DataAccessLayer.Migrations
{
    public partial class add_messages2_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "messages2",
                columns: table => new
                {
                    MessageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: true),
                    ReceiverId = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messages2", x => x.MessageId);
                    table.ForeignKey(
                        name: "FK_messages2_writers_ReceiverId",
                        column: x => x.ReceiverId,
                        principalTable: "writers",
                        principalColumn: "writerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_messages2_writers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "writers",
                        principalColumn: "writerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_messages2_ReceiverId",
                table: "messages2",
                column: "ReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_messages2_SenderID",
                table: "messages2",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "messages2");
        }
    }
}
