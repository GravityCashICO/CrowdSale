using Microsoft.EntityFrameworkCore.Migrations;

namespace Gravity.Data.Migrations
{
    public partial class columnadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JsonTransactions",
                table: "MineTransactions",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StatusType",
                table: "MineTransactions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransactionCount",
                table: "MineTransactions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JsonTransactions",
                table: "MineTransactions");

            migrationBuilder.DropColumn(
                name: "StatusType",
                table: "MineTransactions");

            migrationBuilder.DropColumn(
                name: "TransactionCount",
                table: "MineTransactions");
        }
    }
}
