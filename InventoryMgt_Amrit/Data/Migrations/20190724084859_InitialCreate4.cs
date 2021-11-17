using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InventoryMgt_Amrit.Data.Migrations
{
    public partial class InitialCreate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeftItems",
                table: "StockMaintains",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "StockMaintains",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "SoldItems",
                table: "StockMaintains",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LeftItems",
                table: "StockMaintains");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "StockMaintains");

            migrationBuilder.DropColumn(
                name: "SoldItems",
                table: "StockMaintains");
        }
    }
}
