using Microsoft.EntityFrameworkCore.Migrations;

namespace Gravity.Data.Migrations
{
    public partial class clmType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Received_amount",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 6)");

            migrationBuilder.AlterColumn<string>(
                name: "NetValue",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 6)");

            migrationBuilder.AlterColumn<string>(
                name: "Fee",
                table: "Payments",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 6)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Received_amount",
                table: "Payments",
                type: "decimal(18, 6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NetValue",
                table: "Payments",
                type: "decimal(18, 6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Fee",
                table: "Payments",
                type: "decimal(18, 6)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
