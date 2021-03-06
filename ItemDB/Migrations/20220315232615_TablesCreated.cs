using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemDB.Migrations
{
    public partial class TablesCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstimatedDelivery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShippingMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShippingNotes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "item",
                columns: table => new
                {
                    itemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rarity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Personal_Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Archetype = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item", x => x.itemId);
                    table.ForeignKey(
                        name: "FK_item_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recipient",
                columns: table => new
                {
                    recipientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemOrdered = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recipient", x => x.recipientId);
                    table.ForeignKey(
                        name: "FK_recipient_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_item_OrderId",
                table: "item",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_recipient_OrderId",
                table: "recipient",
                column: "OrderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "item");

            migrationBuilder.DropTable(
                name: "recipient");

            migrationBuilder.DropTable(
                name: "order");
        }
    }
}
