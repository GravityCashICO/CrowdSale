using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gravity.Data.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MineTransactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GasFee = table.Column<decimal>(nullable: false),
                    TotalFee = table.Column<decimal>(nullable: false),
                    totalCoinFee = table.Column<decimal>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastTransactinTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MineTransactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Ipn_id = table.Column<string>(nullable: true),
                    CurrencyCode = table.Column<string>(nullable: true),
                    Received_amount = table.Column<decimal>(nullable: false),
                    Fee = table.Column<decimal>(nullable: false),
                    NetValue = table.Column<decimal>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    AddressToSendCoin = table.Column<string>(nullable: true),
                    CoinAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FromKey = table.Column<string>(nullable: true),
                    ToKey = table.Column<string>(nullable: true),
                    CoinAmount = table.Column<decimal>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    StatusType = table.Column<string>(nullable: true),
                    FeeInCoinAmount = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wallets",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PublicKey = table.Column<string>(nullable: true),
                    PrivateKey = table.Column<string>(nullable: true),
                    TotalCoin = table.Column<decimal>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wallets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wallets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wallets_UserId",
                table: "Wallets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MineTransactions");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "Wallets");
        }
    }
}
