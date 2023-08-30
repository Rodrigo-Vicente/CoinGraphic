using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinGraphic.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CoinHistorics",
                columns: table => new
                {
                    CoinId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    time_period_start = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time_period_end = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time_open = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    time_close = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_open = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_high = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_low = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price_close = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    volume_traded = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trades_count = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoinHistorics", x => x.CoinId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoinHistorics");
        }
    }
}
