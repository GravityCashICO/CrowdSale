using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gravity.Data.Migrations
{
    public partial class infoTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoinPriceUSD = table.Column<double>(nullable: false),
                    PublicKey = table.Column<string>(nullable: true),
                    PrivateKey = table.Column<string>(nullable: true),
                    InfuraUrl = table.Column<string>(nullable: true),
                    Feis = table.Column<double>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    PublicKeyCP = table.Column<string>(nullable: true),
                    PrivateKeyCP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infoes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infoes");
        }
    }
}
