using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItemDB.Migrations
{
    public partial class shippingnotesmadenullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_order_OrderId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_recipient_order_OrderId",
                table: "recipient");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "recipient",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "recipientId",
                table: "recipient",
                newName: "RecipientId");

            migrationBuilder.RenameIndex(
                name: "IX_recipient_OrderId",
                table: "recipient",
                newName: "IX_recipient_OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "order",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "item",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "itemId",
                table: "item",
                newName: "ItemId");

            migrationBuilder.RenameIndex(
                name: "IX_item_OrderId",
                table: "item",
                newName: "IX_item_OrderId");

            migrationBuilder.AlterColumn<string>(
                name: "ItemOrdered",
                table: "recipient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "recipient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ShippingNotes",
                table: "order",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Rarity",
                table: "item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Personal_Notes",
                table: "item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Archetype",
                table: "item",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_item_order_OrderId",
                table: "item",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipient_order_OrderId",
                table: "recipient",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_item_order_OrderId",
                table: "item");

            migrationBuilder.DropForeignKey(
                name: "FK_recipient_order_OrderId",
                table: "recipient");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "recipient",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "RecipientId",
                table: "recipient",
                newName: "recipientId");

            migrationBuilder.RenameIndex(
                name: "IX_recipient_OrderId",
                table: "recipient",
                newName: "IX_recipient_OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "order",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "item",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "item",
                newName: "itemId");

            migrationBuilder.RenameIndex(
                name: "IX_item_OrderId",
                table: "item",
                newName: "IX_item_OrderId");

            migrationBuilder.AlterColumn<string>(
                name: "ItemOrdered",
                table: "recipient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "recipient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShippingNotes",
                table: "order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Rarity",
                table: "item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Personal_Notes",
                table: "item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Archetype",
                table: "item",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_item_order_OrderId",
                table: "item",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_recipient_order_OrderId",
                table: "recipient",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
