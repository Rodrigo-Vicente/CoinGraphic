using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoinGraphic.Migrations
{
    public partial class removeColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "time_open",
                table: "CoinHistorics");

            migrationBuilder.DropColumn(
                name: "time_period_end",
                table: "CoinHistorics");

            migrationBuilder.DropColumn(
                name: "time_period_start",
                table: "CoinHistorics");

            migrationBuilder.DropColumn(
                name: "trades_count",
                table: "CoinHistorics");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "time_open",
                table: "CoinHistorics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "time_period_end",
                table: "CoinHistorics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "time_period_start",
                table: "CoinHistorics",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "trades_count",
                table: "CoinHistorics",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
