using Microsoft.EntityFrameworkCore.Migrations;

namespace Gravity.Data.Migrations
{
    public partial class trnxColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HashHex",
                table: "Transactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Signature",
                table: "Transactions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HashHex",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "Signature",
                table: "Transactions");
        }
    }
}
