using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinGraphic.Migrations
{
    public partial class AlterTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinHistorics");

            migrationBuilder.CreateTable(
                name: "CoinHistoric5ys",
                columns: table => new
                {
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    time_close = table.Column<DateTime>(type: "datetime2", nullable: true),
                    price_open = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_high = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_low = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_close = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    volume_traded = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinHistoric5ys", x => x.CoinId);
                });

            migrationBuilder.CreateTable(
                name: "CoinHistoricLast30Days",
                columns: table => new
                {
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    time_close = table.Column<DateTime>(type: "datetime2", nullable: true),
                    price_open = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_high = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_low = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_close = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    volume_traded = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinHistoricLast30Days", x => x.CoinId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinHistoric5ys");

            migrationBuilder.DropTable(
                name: "CoinHistoricLast30Days");

            migrationBuilder.CreateTable(
                name: "CoinHistorics",
                columns: table => new
                {
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    price_close = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_high = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_low = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    price_open = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    time_close = table.Column<DateTime>(type: "datetime2", nullable: true),
                    volume_traded = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinHistorics", x => x.CoinId);
                });
        }
    }
}
