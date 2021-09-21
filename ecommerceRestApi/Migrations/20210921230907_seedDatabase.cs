using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ecommerceRestApi.Migrations
{
    public partial class seedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_PaymentOptions_PaymentOptionId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PaymentOptionId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("c060ef7e-9bef-46d8-b759-fa3b66bfaac2"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("ec71cab4-11ce-4e33-bf1a-665163d88e19"));

            migrationBuilder.DropColumn(
                name: "PaymentOptionId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("8eac8b20-dee9-46fc-91e2-c6e1efcca693"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("60cc51e5-ffcb-421e-9c8a-c822b950326d"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("60cc51e5-ffcb-421e-9c8a-c822b950326d"));

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: new Guid("8eac8b20-dee9-46fc-91e2-c6e1efcca693"));

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentOptionId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("c060ef7e-9bef-46d8-b759-fa3b66bfaac2"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e2"), "greenPolo.jpg" });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageStatus", "ProductId", "ProductImagePath" },
                values: new object[] { new Guid("ec71cab4-11ce-4e33-bf1a-665163d88e19"), "Primary", new Guid("160c3fad-0479-4e35-9cd9-06427c4bc9e5"), "shirt.png" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentOptionId",
                table: "Orders",
                column: "PaymentOptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_PaymentOptions_PaymentOptionId",
                table: "Orders",
                column: "PaymentOptionId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");
        }
    }
}
