using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gravity.Data.Migrations
{
    public partial class reffaral : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Referrals",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    Bonus = table.Column<string>(nullable: true),
                    Invitation = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false),
                    UserId1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referrals", x => x.Email);
                    table.ForeignKey(
                        name: "FK_Referrals_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Referrals_UserId1",
                table: "Referrals",
                column: "UserId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Referrals");
        }
    }
}
